using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;
using EcommerceAPI.WebAPI.src.Database;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.WebAPI.src.Repository
{
    public class CategoryRepo : ICategoryRepo
    {
        private DbSet<Category> _categories;
        private DatabaseContext _database;
        public CategoryRepo(DatabaseContext database)
        {
            _categories = database.Categories;
            _database = database;
        }
        public Category CreateNewCategory(Category category)
        {
            _categories.Add(category);
            _database.SaveChanges();
            return category;
        }

        public bool DeleteCategory(Guid categoryId)
        {
            var category = _categories.Find(categoryId);
            if (category != null)
            {
                _categories.Remove(category);
                _database.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Category> GetAllCategories(GetAllParams options)
        {
            return _categories.AsNoTracking()
                        .Where(c => c.Name.Contains(options.Search))
                        .Skip(options.Offset)
                        .Take(options.Limit);
        }

        public Category? GetOneCategory(Guid categoryId)
        {
            return _categories.Find(categoryId);
        }

        public bool CheckCategoryExist(Guid categoryId)
        {
            return _categories.Any(c => c.Id == categoryId);
        }

        public bool UpdateCategory(Guid categoryId, Category category)
        {
            var existingCategory = _categories.Find(categoryId);
            if (existingCategory != null)
            {
                existingCategory.Name = category.Name;
                existingCategory.Image = category.Image;
                existingCategory.UpdatedAt = DateTime.Now;
                _database.SaveChanges();
                return true;
            }
            return false;
        }

    }
}