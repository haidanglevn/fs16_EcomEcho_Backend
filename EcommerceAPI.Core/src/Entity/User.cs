namespace EcommerceAPI.Core.src.Entity
{
    public class User : BaseEntity
    {
        public Role Role { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Name { get; set; }
    }
    public enum Role
    {
        Customer,
        Admin
    }
}