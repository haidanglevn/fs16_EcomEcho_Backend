using EcommerceAPI.Core.src.Entity;

namespace EcommerceAPI.Business.src.DTO
{
    public class OrderReadDTO
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public Guid UserId { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
    public class OrderUpdateDTO
    {
        public Status Status { get; set; }
    }

    public class OrderItemCreateDTO
    {
        public Guid ProductId { get; set; }
        public Guid VariantId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class OrderCreateDTO
    {
        public Guid UserId { get; set; }
        public Guid AddressId { get; set; }
        public ICollection<OrderItemCreateDTO> OrderItems { get; set; }
    }
}