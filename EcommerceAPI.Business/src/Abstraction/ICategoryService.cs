using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Parameter;

namespace EcommerceAPI.Business.src.Abstraction
{
    public interface ICategoryService
    {
        IEnumerable<CategoryReadDTO> GetAllCategories(GetAllParams options);
        CategoryReadDTO? GetOneCategory(Guid categoryId);
        CategoryReadDTO CreateNewCategory(CategoryCreateDTO categoryCreateDTO);
        bool UpdateCategory(Guid categoryId, CategoryUpdateDTO categoryUpdateDTO);
        bool DeleteCategory(Guid categoryId);
    }
}