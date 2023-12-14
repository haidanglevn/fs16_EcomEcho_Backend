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
            // _users = new DatabaseContext().Users;
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
                _users.Remove(user);
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
            return _users.Find(userId);
        }

        public bool UpdateUser(Guid userId, User user)
        {
            var existingUser = _database.Users.Find(userId);
            if (existingUser != null)
            {
                existingUser.FirstName = user.FirstName;
                existingUser.LastName = user.LastName;
                _database.SaveChanges();
                return true;
            }
            return false;
        }

        public bool CheckEmail(string email)
        {
            return _database.Users.Any(u => u.Email == email);
        }

    }
}