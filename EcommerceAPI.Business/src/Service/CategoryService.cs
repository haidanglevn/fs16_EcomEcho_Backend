using AutoMapper;
using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;

namespace EcommerceAPI.Business.src.Service
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepo _categoryRepo;
        private IMapper _mapper;
        public CategoryService(ICategoryRepo categoryRepo, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }
        public CategoryReadDTO CreateNewCategory(CategoryCreateDTO categoryCreateDTO)
        {
            var result = _categoryRepo.CreateNewCategory(_mapper.Map<CategoryCreateDTO, Category>(categoryCreateDTO));
            return _mapper.Map<Category, CategoryReadDTO>(result);
        }

        public bool DeleteCategory(Guid categoryId)
        {
            return _categoryRepo.DeleteCategory(categoryId);
        }

        public IEnumerable<CategoryReadDTO> GetAllCategories(GetAllParams options)
        {
            return _categoryRepo.GetAllCategories(options).Select(c => _mapper.Map<Category, CategoryReadDTO>(c));
        }

        public CategoryReadDTO? GetOneCategory(Guid categoryId)
        {
            var category = _categoryRepo.GetOneCategory(categoryId);
            if (category is not null)
            {
                return _mapper.Map<Category, CategoryReadDTO>(category);
            }
            else
            {
                return null;
            }
        }

        public bool UpdateCategory(Guid categoryId, CategoryUpdateDTO categoryUpdateDTO)
        {
            var category = _mapper.Map<CategoryUpdateDTO, Category>(categoryUpdateDTO);
            return _categoryRepo.UpdateCategory(categoryId, category);
        }
    }
}