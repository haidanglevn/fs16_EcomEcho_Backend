namespace EcommerceAPI.Core.src.Entity
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}