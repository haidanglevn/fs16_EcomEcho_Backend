namespace EcommerceAPI.Business.src.DTO
{
    public class AddressReadDTO
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string? State { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
    }
}