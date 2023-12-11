namespace EcommerceAPI.Core.src.Entity
{
    public class Address : BaseEntity
    {
        public string Country { get; set; }

        public string City { get; set; }
        public string? State { get; set; }
        public string Street { get; set; }
        public int PostalCode { get; set; }

        // public User User { get; set; }
    }
}