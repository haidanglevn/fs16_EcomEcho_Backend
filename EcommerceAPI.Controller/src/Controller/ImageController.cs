using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controller.src.Controller
{
    [ApiController]
    [Route("api/[controller]s")]
    public class ImageController : ControllerBase
    {
        private IImageService _imageService;
        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpPost(), Authorize(Roles = "Admin")]
        public ActionResult<ImageReadDTO> AddNewImageToProduct([FromBody] ImageCreateDTO imageCreateDTO)
        {
            try
            {
                var createdImage = _imageService.AddNewImageToProduct(imageCreateDTO);
                return CreatedAtAction(nameof(AddNewImageToProduct), createdImage);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while creating the image.");
            }
        }

        [HttpGet("by-productid/{productId}"), Authorize(Roles = "Admin")]
        public ActionResult<ImageReadDTO> GetImagesByProductId(Guid productId)
        {
            return Ok(_imageService.GetImagesByProductId(productId));
        }

        [HttpPatch("{imageId}"), Authorize(Roles = "Admin")]
        public IActionResult UpdateImage(Guid imageId, [FromBody] ImageUpdateDTO imageUpdateDTO)
        {
            var result = _imageService.UpdateImage(imageId, imageUpdateDTO);
            if (!result)
            {
                return NotFound($"Image with ID {imageId} not found.");
            }
            return Ok($"[ADMIN] Image with ID {imageId} is updated successfully");
        }

        [HttpDelete("{imageId}"), Authorize(Roles = "Admin")]
        public IActionResult DeleteImage(Guid imageId)
        {
            var result = _imageService.DeleteImage(imageId);
            if (!result)
            {
                return NotFound($"Image with ID {imageId} not found.");
            }
            return Ok($"[ADMIN] Image with ID {imageId} is deleted successfully");
        }
    }
}