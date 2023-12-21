using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Parameter;
using Microsoft.AspNetCore.Authorization;
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

        [HttpPost(), Authorize(Roles = "Admin")]
        public ActionResult<ProductReadDTO> CreateNewProduct([FromBody] ProductCreateDTO productCreateDTO)
        {
            return CreatedAtAction(nameof(CreateNewProduct), _productService.CreateNewProduct(productCreateDTO));
        }

        [HttpGet("{productId}")]
        public ActionResult<ProductReadDTO> GetOneProduct(Guid productId)
        {
            return Ok(_productService.GetOneProduct(productId));
        }

        [HttpGet()]
        public ActionResult<IEnumerable<ProductReadDTO>> GetAllProducts([FromQuery] GetAllParams options)
        {
            return Ok(_productService.GetAllProducts(options));
        }

        [HttpPatch("{productId}"), Authorize(Roles = "Admin")]
        public IActionResult UpdateProductById(Guid productId, [FromBody] ProductUpdateDTO productUpdateDTO)
        {
            var result = _productService.UpdateProduct(productId, productUpdateDTO);
            if (!result)
            {
                return NotFound($"Product with ID {productId} not found.");
            }
            return Ok($"[ADMIN] Product with ID {productId} is updated successfully");
        }

        [HttpDelete("{productId}"), Authorize(Roles = "Admin")]
        public IActionResult DeleteProduct(Guid productId)
        {
            var result = _productService.DeleteProduct(productId);
            if (!result)
            {
                return NotFound($"Product with ID {productId} not found.");
            }
            return Ok($"[ADMIN] Product with ID {productId} is deleted successfully");
        }

    }
}