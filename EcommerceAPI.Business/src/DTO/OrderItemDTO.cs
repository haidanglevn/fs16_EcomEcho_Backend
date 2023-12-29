namespace EcommerceAPI.Business.src.DTO
{
    public class OrderItemReadDTO
    {
        public Guid Id { get; set; }
        public Guid VariantId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
    public class OrderItemCreateDTO
    {
        public Guid ProductId { get; set; }
        public Guid VariantId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}