using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;

namespace EcommerceAPI.Core.src.Abstraction
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAllProducts(GetAllParams options);
        Product? GetOneProduct(Guid productId);
        Product CreateNewProduct(Product product);
        bool UpdateProduct(Guid productId, Product product);
        bool DeleteProduct(Guid productId);
    }
}
