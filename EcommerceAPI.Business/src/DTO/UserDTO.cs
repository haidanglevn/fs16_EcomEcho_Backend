using EcommerceAPI.Core.src.Entity;

namespace EcommerceAPI.Business.src.DTO
{
    public class UserReadDTO
    {
        public Guid Id { get; set; }
        public Role Role { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
        public IEnumerable<AddressReadDTO> Addresses { get; set; }
    }
    public class UserReadNoAddressDTO
    {
        public Guid Id { get; set; }
        public Role Role { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    }

    public class UserUpdateDTO
    {
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
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