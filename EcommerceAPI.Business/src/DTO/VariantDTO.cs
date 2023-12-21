using EcommerceAPI.Core.src.Entity;

namespace EcommerceAPI.Business.src.DTO
{
    public class VariantReadDTO
    {
    }

    public class VariantReadSimpleDTO
    {
    }

    public class VariantCreateDTO
    {
        public Color Color { get; set; }
        public Size Size { get; set; }
        public int Quantity { get; set; }
    }

    public class VariantUpdateDTO
    {
    }
}