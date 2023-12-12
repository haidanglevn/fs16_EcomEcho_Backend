namespace EcommerceAPI.Core.src.Entity
{
    public class Category : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}