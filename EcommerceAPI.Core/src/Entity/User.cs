namespace EcommerceAPI.Core.src.Entity
{
    public class User : BaseEntity
    {
        public Role Role { get; set; } = Role.Customer;
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        // Navigation properties
        public IEnumerable<Address> Addresses { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
    public enum Role
    {
        Customer,
        Admin
    }
}