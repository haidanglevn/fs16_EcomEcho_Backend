using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Parameter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controller.src.Controller
{
    [ApiController]
    [Route("api/categories")]

    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet()]
        public ActionResult<IEnumerable<CategoryReadDTO>> GetAllCategories([FromQuery] GetAllParams options)
        {
            return Ok(_categoryService.GetAllCategories(options));
        }

        [HttpGet("{categoryId}")]
        public ActionResult<CategoryReadDTO> GetOneCategory(Guid categoryId)
        {
            return Ok(_categoryService.GetOneCategory(categoryId));
        }

        [HttpPost(), Authorize(Roles = "Admin")]
        public ActionResult<CategoryReadDTO> CreateNewCategory([FromBody] CategoryCreateDTO categoryCreateDTO)
        {
            return CreatedAtAction(nameof(CreateNewCategory), _categoryService.CreateNewCategory(categoryCreateDTO));
        }

        [HttpPatch("{categoryId}"), Authorize(Roles = "Admin")]
        public IActionResult UpdateCategory(Guid categoryId, [FromBody] CategoryUpdateDTO categoryUpdateDTO)
        {
            var result = _categoryService.UpdateCategory(categoryId, categoryUpdateDTO);
            if (!result)
            {
                return NotFound($"Category with ID {categoryId} not found.");
            }
            return Ok($"[ADMIN] Category with ID {categoryId} is updated successfully");
        }

        [HttpDelete("{categoryId}"), Authorize(Roles = "Admin")]
        public IActionResult DeleteCategory(Guid categoryId)
        {
            var result = _categoryService.DeleteCategory(categoryId);
            if (!result)
            {
                return NotFound($"Category with ID {categoryId} not found.");
            }
            return Ok($"[ADMIN] Category with ID {categoryId} is deleted successfully");
        }
    }
}