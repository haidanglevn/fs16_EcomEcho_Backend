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
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers(GetAllParams options)
        {
            return _users.Where(u => u.FirstName.Contains(options.Search)).Skip(options.Offset).Take(options.Limit);
        }

        public User? FindByEmail(string email)
        {
            return _database.Users.FirstOrDefault(u => u.Email == email);
        }

        public User GetOneUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(User updatedUser)
        {
            throw new NotImplementedException();
        }
    }
}