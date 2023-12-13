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
        private readonly IPasswordHasher _passwordHasher;
        public UserService(IUserRepo userRepo, IMapper mapper, IPasswordHasher passwordHasher)
        {
            _userRepo = userRepo;
            _mapper = mapper;
            _passwordHasher = passwordHasher;
        }
        public UserReadDTO CreateNewUser(UserCreateDTO userCreateDTO)
        {
            var passwordHash = _passwordHasher.HashPassword(userCreateDTO.Password);

            var hashUserCreateDTO = new UserCreateDTO
            {
                Email = userCreateDTO.Email,
                FirstName = userCreateDTO.FirstName,
                LastName = userCreateDTO.LastName,
                Password = passwordHash,
            };

            var result = _userRepo.CreateNewUser(_mapper.Map<UserCreateDTO, User>(hashUserCreateDTO));
            return _mapper.Map<User, UserReadDTO>(result);
        }

        public UserReadDTO? Login(string email, string userInputPassword)
        {
            var user = _userRepo.FindByEmail(email);
            if (user != null && _passwordHasher.VerifyPassword(user.Password, userInputPassword))
            {
                return _mapper.Map<User, UserReadDTO>(user);
            }
            return null;
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