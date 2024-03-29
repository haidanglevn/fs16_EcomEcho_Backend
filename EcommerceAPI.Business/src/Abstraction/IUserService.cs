using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Parameter;

namespace EcommerceAPI.Business.src.Abstraction
{
    public interface IUserService
    {
        IEnumerable<UserReadNoAddressDTO> GetAllUsers(GetAllParams options);
        UserReadDTO? GetOneUser(Guid userId);
        UserReadSimpleDTO? GetOneUserSimple(Guid userId);
        UserReadDTO CreateNewUser(UserCreateDTO user);
        UserReadDTO CreateNewAdminUser(UserCreateAdminDTO user);
        UserReadDTO? Login(string email, string userInputPassword);
        bool CheckEmail(string email);
        bool UpdateUser(Guid userId, UserUpdateDTO userUpdateDTO);
        bool DeleteUser(Guid userId);
        bool ChangePassword(Guid userId, UserChangePasswordDTO userChangePasswordDTO);
    }
}