namespace EcommerceAPI.Core.src.Entity
{
    public class Review : BaseEntity
    {
        public int Rating { get; set; }
        public string Comment { get; set; }

        // Navigation properties
        // public User User { get; set; }
        // public Product Product { get; set; }
    }
}