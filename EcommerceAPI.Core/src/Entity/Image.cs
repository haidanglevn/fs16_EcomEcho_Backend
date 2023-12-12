namespace EcommerceAPI.Core.src.Entity
{
    public class Image
    {
        public Guid Id { get; set; } // Primary key
        public string Url { get; set; } // The URL to the image

        // Navigation property back to the Product
        // public Product Product { get; set; }
    }
}