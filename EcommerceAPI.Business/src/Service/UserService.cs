using System.Text.Json;
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
                Avatar = userCreateDTO.Avatar,
                Password = passwordHash,
            };

            var result = _userRepo.CreateNewUser(_mapper.Map<UserCreateDTO, User>(hashUserCreateDTO));
            return _mapper.Map<User, UserReadDTO>(result);
        }
        public UserReadDTO CreateNewAdminUser(UserCreateAdminDTO userCreateAdminDTO)
        {
            var passwordHash = _passwordHasher.HashPassword(userCreateAdminDTO.Password);

            var hashUserCreateDTO = new UserCreateAdminDTO
            {
                Email = userCreateAdminDTO.Email,
                FirstName = userCreateAdminDTO.FirstName,
                LastName = userCreateAdminDTO.LastName,
                Avatar = userCreateAdminDTO.Avatar,
                Password = passwordHash,
                Role = userCreateAdminDTO.Role
            };

            var result = _userRepo.CreateNewUser(_mapper.Map<UserCreateAdminDTO, User>(hashUserCreateDTO));
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

        public bool CheckEmail(string email)
        {
            return _userRepo.CheckEmail(email);
        }
        public bool DeleteUser(Guid userId)
        {
            return _userRepo.DeleteUser(userId);
        }

        public IEnumerable<UserReadNoAddressDTO> GetAllUsers(GetAllParams options)
        {
            return _userRepo.GetAllUsers(options).Select(u => _mapper.Map<User, UserReadNoAddressDTO>(u));
        }

        public UserReadDTO? GetOneUser(Guid userId)
        {
            var user = _userRepo.GetOneUser(userId);
            if (user is not null)
            {
                return _mapper.Map<User, UserReadDTO>(user);
            }
            else
            {
                return null;
            }
        }
        // A basic read one for simplier return of user, without authorization
        public UserReadSimpleDTO? GetOneUserSimple(Guid userId)
        {
            var user = _userRepo.GetOneUser(userId);
            if (user is not null)
            {
                return _mapper.Map<User, UserReadSimpleDTO>(user);
            }
            else
            {
                return null;
            }
        }

        public bool UpdateUser(Guid userId, UserUpdateDTO userUpdateDTO)
        {
            var existingUser = _userRepo.GetOneUser(userId);
            if (existingUser is not null)
            {
                var user = _mapper.Map<UserUpdateDTO, User>(userUpdateDTO, existingUser);
                return _userRepo.UpdateUser(userId, user);
            }
            else
            {
                throw new Exception("Invalid userID");
            }
        }

        public bool ChangePassword(Guid userId, UserChangePasswordDTO userChangePasswordDTO)
        {
            var user = _userRepo.GetOneUser(userId) ?? throw new Exception("User not found.");

            if (!_passwordHasher.VerifyPassword(user.Password, userChangePasswordDTO.CurrentPassword))
            {
                throw new Exception("Current password is incorrect.");
            }

            if (userChangePasswordDTO.NewPassword != userChangePasswordDTO.ConfirmNewPassword)
            {
                throw new Exception("New password and confirmation password do not match.");
            }

            if (_passwordHasher.VerifyPassword(user.Password, userChangePasswordDTO.NewPassword))
            {
                throw new Exception("New password cannot be the same as the current password.");
            }

            user.Password = _passwordHasher.HashPassword(userChangePasswordDTO.NewPassword);
            return _userRepo.UpdateUser(user.Id, user);
        }
    }
}