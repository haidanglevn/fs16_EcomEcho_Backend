namespace EcommerceAPI.Business.src.DTO
{
    public class ImageReadDTO
    {
        public string Url { get; set; }
        public Guid Id { get; set; }
    }
    public class ImageUpdateDTO
    {
        public string Url { get; set; }
    }
    public class ImageCreateDTO
    {
        public string Url { get; set; }
        public Guid ProductId { get; set; }
    }
}