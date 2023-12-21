using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controller.src.Controller
{
    [ApiController]
    [Route("api/[controller]s")]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public ActionResult<ProductReadDTO> CreateNewProduct([FromBody] ProductCreateDTO productCreateDTO)
        {
            return CreatedAtAction(nameof(CreateNewProduct), _productService.CreateNewProduct(productCreateDTO));
        }
    }
}