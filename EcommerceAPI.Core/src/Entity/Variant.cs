namespace EcommerceAPI.Core.src.Entity
{
    public class Variant : BaseEntity
    {
        public Color Color { get; set; } = Color.Black;
        public Size Size { get; set; } = Size.XS;
        public int Quantity { get; set; } // Quantity available for this variant

        public Guid ProductId { get; set; } // Foreign key to Product
        // Navigation property back to the Product
        // public Product Product { get; set; }
    }

    public enum Color
    {
        Black,
        Silver,
        Gray,
        White,
        Maroon,
        Red,
        Purple,
        Fuchsia,
        Green,
        Lime,
        Olive,
        Yellow,
        Navy,
        Blue,
        Teal,
        Aqua,
        Orange,
        AliceBlue,
        Coral,
        DarkBlue
    }

    public enum Size
    {
        XS,
        S,
        M,
        L,
        XL,
        XXL,
        XXXL
    }


}