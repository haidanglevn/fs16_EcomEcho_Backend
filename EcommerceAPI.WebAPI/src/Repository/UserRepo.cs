using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;
using EcommerceAPI.WebAPI.src.Database;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.WebAPI.src.Repository
{
    public class UserRepo : IUserRepo
    {
        private DbSet<User> _users;
        private DatabaseContext _database;
        public UserRepo(DatabaseContext database)
        {
            _users = database.Users;
            _database = database;
        }
        public User CreateNewUser(User user)
        {
            _users.Add(user);
            _database.SaveChanges();
            return user;
        }

        public bool DeleteUser(Guid userId)
        {
            var user = _users.Find(userId);
            if (user != null)
            {
                user.IsDeleted = true;
                _database.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<User> GetAllUsers(GetAllParams options)
        {
            return _users.AsNoTracking()
            .Where(u => u.FirstName.Contains(options.Search))
            .Skip(options.Offset)
            .Take(options.Limit);
            // AsNoTracking() helps improve excution time for large db, as this function doesn't change 
        }

        public User? FindByEmail(string email)
        {
            return _users.AsNoTracking().FirstOrDefault(u => u.Email == email);
        }

        public User? GetOneUser(Guid userId)
        {
            return _users.Include(u => u.Addresses).FirstOrDefault(u => u.Id == userId);
        }

        public bool UpdateUser(Guid userId, User user)
        {
            var existingUser = _database.Users.Find(userId);
            if (existingUser != null)
            {
                UpdateEntityFields(existingUser, user);
                existingUser.UpdatedAt = DateTime.Now;
                _database.SaveChanges();
                return true;
            }
            return false;
        }

        private void UpdateEntityFields(User existingUser, User user)
        {
            var dtoProperties = user.GetType().GetProperties();
            foreach (var dtoProp in dtoProperties)
            {
                // Skip key properties
                if (_database.Entry(existingUser).Metadata.FindPrimaryKey()!.Properties.Any(p => p.Name == dtoProp.Name))
                {
                    continue;
                }
                var value = dtoProp.GetValue(user);
                if (value != null)
                {
                    var entityProp = existingUser.GetType().GetProperty(dtoProp.Name);
                    if (entityProp != null && entityProp.CanWrite)
                    {
                        entityProp.SetValue(existingUser, value);
                    }
                }
            }
        }

        public bool CheckEmail(string email)
        {
            return _database.Users.Any(u => u.Email == email);
        }
        public bool CheckUserExist(Guid userId)
        {
            return _users.Any(c => c.Id == userId);
        }
    }
}