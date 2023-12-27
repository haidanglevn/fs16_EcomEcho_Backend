namespace EcommerceAPI.Core.src.Entity
{
    public class Order : BaseEntity
    {
        public Status Status { get; set; } = Status.Pending;
        public Guid UserId { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }

    public enum Status
    {
        Pending,
        Shipping,
        Received
    }
}