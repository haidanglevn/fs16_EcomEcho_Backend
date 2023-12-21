using AutoMapper;
using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;

namespace EcommerceAPI.Business.src.Service
{
    public class ProductService : IProductService
    {
        private IProductRepo _productRepo;
        private ICategoryRepo _categoryRepo;
        private IMapper _mapper;
        public ProductService(IProductRepo productRepo, IMapper mapper, ICategoryRepo categoryRepo)
        {
            _productRepo = productRepo;
            _mapper = mapper;
            _categoryRepo = categoryRepo;
        }
        public ProductReadDTO CreateNewProduct(ProductCreateDTO productCreateDTO)
        {
            var isCategoryExist = _categoryRepo.CheckCategoryExist(productCreateDTO.CategoryId);
            if (isCategoryExist)
            {
                var result = _productRepo.CreateNewProduct(_mapper.Map<ProductCreateDTO, Product>(productCreateDTO));
                return _mapper.Map<Product, ProductReadDTO>(result);
            }
            else
            {
                throw new Exception("Invalid Category Id, please check again.");
            }
        }

        public bool DeleteProduct(Guid productId)
        {
            return _productRepo.DeleteProduct(productId);
        }

        public IEnumerable<ProductReadSimpleDTO> GetAllProducts(GetAllParams options)
        {
            return _productRepo.GetAllProducts(options).Select(p => _mapper.Map<Product, ProductReadSimpleDTO>(p));
        }

        public ProductReadDTO? GetOneProduct(Guid productId)
        {
            var product = _productRepo.GetOneProduct(productId);
            if (product is not null)
            {
                return _mapper.Map<Product, ProductReadDTO>(product);
            }
            else
            {
                return null;
            }
        }

        public bool UpdateProduct(Guid productId, ProductUpdateDTO productUpdateDTO)
        {
            var product = _mapper.Map<ProductUpdateDTO, Product>(productUpdateDTO);
            return _productRepo.UpdateProduct(productId, product);
        }
    }
}