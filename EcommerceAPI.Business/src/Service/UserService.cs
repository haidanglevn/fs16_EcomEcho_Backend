using AutoMapper;
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
        private IMapper _mapper;
        public UserService(IUserRepo userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }
        public UserReadDTO CreateNewUser(UserCreateDTO userCreateDTO)
        {
            var result = _userRepo.CreateNewUser(_mapper.Map<UserCreateDTO, User>(userCreateDTO));
            return _mapper.Map<User, UserReadDTO>(result);
        }

        public bool DeleteUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserReadDTO> GetAllUsers(GetAllParams options)
        {
            return _userRepo.GetAllUsers(options).Select(u => _mapper.Map<User, UserReadDTO>(u));
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