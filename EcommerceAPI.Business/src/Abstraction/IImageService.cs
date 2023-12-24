using EcommerceAPI.Business.src.DTO;

namespace EcommerceAPI.Business.src.Abstraction
{
    public interface IImageService
    {
        IEnumerable<ImageReadDTO> GetImagesByProductId(Guid productId);
        ImageReadDTO AddNewImageToProduct(ImageCreateDTO imageCreateDTO);
        bool UpdateImage(Guid imageId, ImageUpdateDTO imageUpdateDTO);
        bool DeleteImage(Guid imageId);
    }
}