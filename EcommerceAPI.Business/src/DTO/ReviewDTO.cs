namespace EcommerceAPI.Business.src.DTO
{
    public class ReviewReadDTO
    {
        public Guid Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
    }
    public class ReviewCreateDTO
    {
        public int Rating { get; set; }
        public string Comment { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
    }
    public class ReviewUpdateDTO
    {
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}