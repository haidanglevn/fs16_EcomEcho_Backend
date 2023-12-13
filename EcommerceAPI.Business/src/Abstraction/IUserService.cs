using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;

namespace EcommerceAPI.Business.src.Abstraction
{
    public interface IUserService
    {
        IEnumerable<UserReadDTO> GetAllUsers(GetAllParams options);
        UserReadDTO GetOneUser(Guid userId);
        UserReadDTO CreateNewUser(UserCreateDTO user);
        public UserReadDTO? Login(string email, string userInputPassword);
        bool UpdateUser(UserUpdateDTO updatedUser);
        bool DeleteUser(Guid userId);
    }
}