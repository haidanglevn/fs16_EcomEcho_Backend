using EcommerceAPI.Core.src.Entity;

namespace EcommerceAPI.Business.src.DTO
{
    public class OrderReadDTO
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public Guid UserId { get; set; }
        public Guid AddressId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string? Avatar { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        public ICollection<OrderItemReadDTO> OrderItems { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
    public class OrderUpdateDTO
    {
        public Status Status { get; set; }
    }

    public class OrderCreateDTO
    {
        public Guid UserId { get; set; }
        public Guid AddressId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string? Avatar { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        public ICollection<OrderItemCreateDTO> OrderItems { get; set; }
    }
}