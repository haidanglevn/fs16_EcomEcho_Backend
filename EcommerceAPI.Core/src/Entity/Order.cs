namespace EcommerceAPI.Core.src.Entity
{
    public class Order : BaseEntity
    {
        public Status Status { get; set; } = Status.Pending;
        public Guid UserId { get; set; }
        public Guid AddressId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string? Avatar { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }

    public enum Status
    {
        Pending,
        Shipping,
        Received
    }
}

