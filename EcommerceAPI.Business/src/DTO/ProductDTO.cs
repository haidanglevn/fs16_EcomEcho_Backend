using EcommerceAPI.Core.src.Entity;

namespace EcommerceAPI.Business.src.DTO
{
    public class ProductReadDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
        public ICollection<Variant> Variants { get; set; }

        // Implement later
        // public ICollection<Image> Images { get; set; }
        // public ICollection<Review> Reviews { get; set; }
    }

    // Simple DTO for getAll performance
    public class ProductReadSimpleDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductCreateDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
        public ICollection<VariantCreateDTO> Variants { get; set; }

        // Implement later
        // public ICollection<Image> Images { get; set; }
        // public ICollection<Review> Reviews { get; set; }
    }

    public class ProductUpdateDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<Variant> Variants { get; set; }

        // Implement later
        // public ICollection<Image> Images { get; set; }
        // public ICollection<Review> Reviews { get; set; }
    }
}