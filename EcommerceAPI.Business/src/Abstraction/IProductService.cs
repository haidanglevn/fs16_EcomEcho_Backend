using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Parameter;

namespace EcommerceAPI.Business.src.Abstraction
{
    public interface IProductService
    {
        IEnumerable<ProductReadSimpleDTO> GetAllProducts(GetAllParams options);
        ProductReadDTO? GetOneProduct(Guid productId);
        ProductReadDTO CreateNewProduct(ProductCreateDTO productCreateDTO);
        bool UpdateProduct(Guid productId, ProductUpdateDTO productUpdateDTO);
        bool DeleteProduct(Guid productId);
    }
}