using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;

namespace EcommerceAPI.Business.src.Service
{
    public class UserService : IUserService
    {
        private IUserRepo _userRepo;
        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public bool CreateNewUser(UserCreateDTO userCreateDTO)
        {
            var result = _userRepo.CreateNewUser(userCreateDTO.Transform());
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserReadDTO> GetAllUsers(GetAllParams options)
        {
            return _userRepo.GetAllUsers(options).Select(u => new UserReadDTO().Convert(u));
        }

        public UserReadDTO GetOneUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(UserUpdateDTO updatedUser)
        {
            throw new NotImplementedException();
        }
    }
}