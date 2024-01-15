using AutoMapper;
using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Business.src.Service;
using EcommerceAPI.Business.src.Shared;
using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;
using FluentAssertions;
using Moq;

namespace EcommerceAPI.Test
{
    public class UserServiceTests
    {
        private readonly Mock<IUserRepo> _mockUserRepo;
        private readonly IMapper _mapper;
        private readonly PasswordHasher _passwordHasher;
        private readonly UserService _userService;
        public UserServiceTests()
        {
            _mockUserRepo = new Mock<IUserRepo>();
            var mapperProfile = new MapperProfile();
            var config = new MapperConfiguration(cfg => cfg.AddProfile(mapperProfile));
            _mapper = new Mapper(config);
            _passwordHasher = new PasswordHasher();

            _userService = new UserService(_mockUserRepo.Object, _mapper, _passwordHasher);
        }

        [Fact]
        public void UserService_GetAllUsers_ShouldReturnAllUsers()
        {
            GetAllParams options = new();

            var users = new List<User>{
                new() {
                    Id = Guid.NewGuid(),
                    FirstName = "Admin",
                    LastName = "admin",
                    Email = "admin@mail.com",
                    Avatar = "https://picsum.photos/1000/1000?random=150",
                    Password = "admin",
                    Role = Role.Admin
                },
                new() {
                    Id = Guid.NewGuid(),
                    FirstName = "John",
                    LastName = "Cena",
                    Email = "cena@mail.com",
                    Avatar = "https://picsum.photos/1000/1000?random=151",
                    Password = "password",
                    Role = Role.Customer
                },
            };

            _mockUserRepo.Setup(repo => repo.GetAllUsers(options)).Returns(users.AsEnumerable());
            var result = _userService.GetAllUsers(options);

            result.Should().NotBeNullOrEmpty();
            result.Should().HaveCount(2);
        }

        [Fact]
        public void UserService_Login_ShouldReturnUser()
        {
            var email = "test@email.com";
            var password = "password";
            var hashed = _passwordHasher.HashPassword(password);
            var mockUser = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Admin",
                LastName = "admin",
                Email = "test@email.com",
                Avatar = "https://picsum.photos/1000/1000?random=150",
                Password = hashed,
                Role = Role.Admin
            };
            _mockUserRepo.Setup(repo => repo.FindByEmail(email)).Returns(mockUser);
            var result = _userService.Login(email, password);

            _mockUserRepo.Verify(repo => repo.FindByEmail(email), Times.Once);
        }

        [Fact]
        public void UserService_CheckEmail_ShouldReturnTrue()
        {
            var email = "test@email.com";

            _mockUserRepo.Setup(r => r.CheckEmail(email)).Returns(true);

            var result = _userService.CheckEmail(email);

            result.Should().BeTrue();
        }

        [Fact]
        public void UserService_DeleteUser_ShouldReturnTrue()
        {
            var mockUser = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Admin",
                LastName = "admin",
                Email = "test@email.com",
                Avatar = "https://picsum.photos/1000/1000?random=150",
                Password = "password",
                Role = Role.Admin
            };


            _mockUserRepo.Setup(r => r.DeleteUser(mockUser.Id)).Returns(true);

            var result = _userService.DeleteUser(mockUser.Id);

            result.Should().BeTrue();
        }

        [Fact]
        public void UserService_GetOneUser_ShouldReturnAUser()
        {
            var mockUser = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Admin",
                LastName = "admin",
                Email = "test@email.com",
                Avatar = "https://picsum.photos/1000/1000?random=150",
                Password = "password",
                Role = Role.Admin
            };


            _mockUserRepo.Setup(r => r.GetOneUser(mockUser.Id)).Returns(mockUser);

            var result = _userService.GetOneUser(mockUser.Id);

            _mockUserRepo.Verify(r => r.GetOneUser(mockUser.Id), Times.Once);
            result.Should().BeOfType(typeof(UserReadDTO));
        }

    }
}