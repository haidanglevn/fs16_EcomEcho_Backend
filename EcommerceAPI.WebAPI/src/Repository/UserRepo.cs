using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;
using EcommerceAPI.WebAPI.src.Database;

namespace EcommerceAPI.WebAPI.src.Repository
{
    public class UserRepo : IUserRepo
    {
        private List<User> _users;
        public UserRepo()
        {
            _users = new DatabaseContext().Users;
        }
        public bool CreateNewUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers(GetAllParams options)
        {
            return _users.Where(u => u.FirstName.Contains(options.Search)).Skip(options.Offset).Take(options.Limit);
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