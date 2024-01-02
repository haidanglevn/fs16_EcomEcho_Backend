using AutoMapper;
using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Business.src.Service;
using EcommerceAPI.Business.src.Shared;
using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;
using FluentAssertions;
using Moq;

namespace EcommerceAPI.Test
{
    public class CategoryServiceTests
    {
        private readonly Mock<ICategoryRepo> _mockCategoryRepo;
        private readonly IMapper _mapper;
        private readonly CategoryService _categoryService;
        public CategoryServiceTests()
        {
            _mockCategoryRepo = new Mock<ICategoryRepo>();
            var mapperProfile = new MapperProfile();
            var config = new MapperConfiguration(cfg => cfg.AddProfile(mapperProfile));
            _mapper = new Mapper(config);
            _categoryService = new CategoryService(_mockCategoryRepo.Object, _mapper);
        }

        [Fact]
        public void CategoryService_DeleteCategory_ShouldReturnTrue()
        {
            Category mockCategory = new()
            {
                Id = Guid.NewGuid()
            };

            _mockCategoryRepo.Setup(r => r.DeleteCategory(mockCategory.Id)).Returns(true);

            var result = _categoryService.DeleteCategory(mockCategory.Id);

            result.Should().BeTrue();
        }

        [Fact]
        public void CategoryService_GetAllCategories_ShouldReturnAllCategories()
        {
            var mockCategories = new List<Category>
            {
               new(){Id = Guid.NewGuid()},
               new(){Id = Guid.NewGuid()},
               new(){Id = Guid.NewGuid()}
            };
            GetAllParams options = new();


            _mockCategoryRepo.Setup(r => r.GetAllCategories(options)).Returns(mockCategories);

            var result = _categoryService.GetAllCategories(options);

            result.Should().HaveCount(3);
            result.Should().NotBeNullOrEmpty();
        }
        [Fact]
        public void CategoryService_GetOneCategory_ShouldReturnOneCategory()
        {
            Category mockCategory = new()
            {
                Id = Guid.NewGuid()
            };

            _mockCategoryRepo.Setup(r => r.GetOneCategory(mockCategory.Id)).Returns(mockCategory);

            var result = _categoryService.GetOneCategory(mockCategory.Id);

            result.Should().BeEquivalentTo(_mapper.Map<CategoryReadDTO>(mockCategory));
        }
        [Fact]
        public void CategoryService_CreateNewCategory_ShouldReturnTrue()
        {
            Category mockCategory = new()
            {
                Id = Guid.NewGuid()
            };
            CategoryCreateDTO categoryCreateDTO = new();

            _mockCategoryRepo.Setup(r => r.CreateNewCategory(mockCategory)).Returns(mockCategory);

            var result = _categoryService.CreateNewCategory(categoryCreateDTO);

            // result.Should().BeTrue();
            // _mockCategoryRepo.Verify(r => r.CreateNewCategory(_mapper.Map<CategoryCreateDTO, Category>(categoryCreateDTO)), Times.Once);

        }

    }
}