using EcommerceAPI.Core.src.Entity;

namespace EcommerceAPI.Business.src.DTO
{
    public class UserReadDTO
    {
        public Role Role { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    }

    public class UserUpdateDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
    public class UserLoginDTO
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
    public class UserCreateDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class CheckEmailDTO
    {
        public string Email { get; set; }
    }
}