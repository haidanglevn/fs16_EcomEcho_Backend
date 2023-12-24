namespace EcommerceAPI.Core.src.Entity
{
    public class Image : BaseEntity
    {
        public string Url { get; set; }
        public Guid ProductId { get; set; }

        // Navigation property back to the Product
        // public Product Product { get; set; }
    }
}