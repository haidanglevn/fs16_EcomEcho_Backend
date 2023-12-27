namespace EcommerceAPI.Core.src.Entity
{
    public class Address : BaseEntity
    {
        public string Country { get; set; }

        public string City { get; set; }
        public string? State { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public Guid UserId { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}