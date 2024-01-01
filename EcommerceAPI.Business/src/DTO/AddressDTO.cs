namespace EcommerceAPI.Business.src.DTO
{
    public class AddressReadDTO
    {
        public Guid Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string? State { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
    }
    public class AddressCreateDTO
    {
        public Guid UserId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string? State { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
    }
    public class AddressUpdateDTO
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string? State { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
    }
}