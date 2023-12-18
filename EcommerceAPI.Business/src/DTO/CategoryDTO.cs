using EcommerceAPI.Core.src.Entity;

namespace EcommerceAPI.Business.src.DTO
{
    public class CategoryReadDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
    public class CategoryWithProductReadDTO
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public IEnumerable<Product> Products { get; set; }

    }
    public class CategoryUpdateDTO
    {
        public string Name { get; set; }
        public string Image { get; set; }
    }
    public class CategoryCreateDTO
    {
        public string Name { get; set; }
        public string Image { get; set; }
    }
}