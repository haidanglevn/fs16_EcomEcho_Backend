using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;

namespace EcommerceAPI.Core.src.Abstraction
{
    public interface IUserRepo
    {
        IEnumerable<User> GetAllUsers(GetAllParams options);
        User? GetOneUser(Guid userId);
        User CreateNewUser(User user);
        User? FindByEmail(string email);
        bool CheckEmail(string email);
        bool UpdateUser(Guid userId, User user);
        bool DeleteUser(Guid userId);
    }
}