using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;

namespace EcommerceAPI.Core.src.Abstraction
{
    public interface IUserRepo
    {
        IEnumerable<User> GetAllUsers(GetAllParams options);
        User GetOneUser(Guid userId);
        bool CreateNewUser(User user);
        bool UpdateUser(User updatedUser);
        bool DeleteUser(Guid userId);
    }
}