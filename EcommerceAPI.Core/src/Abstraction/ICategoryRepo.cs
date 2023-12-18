using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;

namespace EcommerceAPI.Core.src.Abstraction
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> GetAllCategories(GetAllParams options);
        Category? GetOneCategory(Guid categoryId);
        Category CreateNewCategory(Category category);
        bool UpdateCategory(Guid categoryId, Category category);
        bool DeleteCategory(Guid categoryId);
    }
}