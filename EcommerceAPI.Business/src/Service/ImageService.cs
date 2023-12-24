using AutoMapper;
using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;

namespace EcommerceAPI.Business.src.Service
{
    public class ImageService : IImageService
    {
        private IImageRepo _imageRepo;
        private IMapper _mapper;
        private IProductRepo _productRepo;
        public ImageService(IMapper mapper, IImageRepo imageRepo, IProductRepo productRepo)
        {
            _imageRepo = imageRepo;
            _mapper = mapper;
            _productRepo = productRepo;
        }

        public ImageReadDTO AddNewImageToProduct(ImageCreateDTO imageCreateDTO)
        {
            var isProductExist = _productRepo.CheckProductExist(imageCreateDTO.ProductId);
            if (isProductExist)
            {
                var result = _imageRepo.AddNewImageToProduct(_mapper.Map<ImageCreateDTO, Image>(imageCreateDTO));
                return _mapper.Map<ImageReadDTO>(result);
            }
            else
            {
                throw new Exception("Invalid Product Id, please check again");
            }
        }

        public bool DeleteImage(Guid imageId)
        {
            return _imageRepo.DeleteImage(imageId);
        }

        public bool UpdateImage(Guid imageId, ImageUpdateDTO imageUpdateDTO)
        {
            var image = _mapper.Map<Image>(imageUpdateDTO);
            return _imageRepo.UpdateImage(imageId, image);
        }

        public IEnumerable<ImageReadDTO> GetImagesByProductId(Guid productId)
        {
            return _imageRepo.GetImagesByProductId(productId).Select(i => _mapper.Map<ImageReadDTO>(i));
        }

    }
}