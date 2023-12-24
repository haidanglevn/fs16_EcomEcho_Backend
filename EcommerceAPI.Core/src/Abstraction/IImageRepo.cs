using EcommerceAPI.Core.src.Entity;

namespace EcommerceAPI.Core.src.Abstraction
{
    public interface IImageRepo
    {
        IEnumerable<Image> GetImagesByProductId(Guid productId);
        Image AddNewImageToProduct(Image image);
        bool UpdateImage(Guid imageId, Image image);
        bool DeleteImage(Guid imageId);
    }
}