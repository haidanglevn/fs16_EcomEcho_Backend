using System.Diagnostics;
using AutoMapper;
using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Business.src.Service;
using EcommerceAPI.Business.src.Shared;
using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;
using FluentAssertions;
using Moq;
using Newtonsoft.Json;
using Xunit.Sdk;

namespace EcommerceAPI.Test
{
    public class ProductServiceTests
    {
        private readonly ProductService _productService;
        private readonly Mock<IProductRepo> _mockProductRepo;
        private readonly Mock<ICategoryRepo> _mockCategoryRepo;
        private IMapper _mapper;
        public static readonly Guid FashionProduct1Guid = Guid.Parse("bc2983a5-b13c-49a4-9a6c-29c4dad9c355");
        public static readonly Guid FashionProduct2Guid = Guid.Parse("fedfd1c9-a73a-47bf-a635-370c193fc1df");
        public static readonly Guid Category1Guid = Guid.Parse("88499694-269b-4308-a64d-0e903a1f503d");
        public GetAllParams options;
        public Product mockProduct1 = new()
        {
            Id = FashionProduct1Guid,
            Title = "Fashion Product 1",
            Description = "Description for Fashion Product 1",
            Price = 100,
            CategoryId = Category1Guid,
        };
        public Product mockProduct2 = new()
        {
            Id = FashionProduct2Guid,
            Title = "Fashion Product 2",
            Description = "Description for Fashion Product 2",
            Price = 140,
            CategoryId = Category1Guid,
        };

        public ProductCreateDTO product3CreateDTO = new()
        {
            Title = "Fashion Product 3",
            Description = "Description for Fashion Product 3",
            Price = 160,
            CategoryId = Category1Guid,
        };

        public ProductUpdateDTO product3UpdateDTO = new()
        {
            Title = "Fashion Product 3",
            Description = "Description for Fashion Product 3",
            Price = 160,
        };

        public Product mockProduct3 = new()
        {
            Id = Guid.NewGuid(),
            Title = "Fashion Product 3",
            Description = "Description for Fashion Product 3",
            Price = 160,
            CategoryId = Category1Guid,
        };

        public List<Product> mockProducts;

        public ProductServiceTests()
        {
            options = new GetAllParams { Limit = 10, Offset = 0, Search = "" };
            _mockProductRepo = new Mock<IProductRepo>();
            _mockCategoryRepo = new Mock<ICategoryRepo>();
            var mapperProfile = new MapperProfile();
            var config = new MapperConfiguration(cfg => cfg.AddProfile(mapperProfile));
            _mapper = new Mapper(config);

            mockProducts = new()
            {
                mockProduct1, mockProduct2
            };

            ProductCreateDTO product3CreateDTO = new()
            {
                Title = "Fashion Product 3",
                Description = "Description for Fashion Product 3",
                Price = 160,
                CategoryId = Category1Guid,
            };

            var mockProduct3 = new Product
            {
                Id = Guid.NewGuid(),
                Title = "Fashion Product 3",
                Description = "Description for Fashion Product 3",
                Price = 160,
                CategoryId = Category1Guid,
            };

            _mockProductRepo.Setup(repo => repo.DeleteProduct(FashionProduct2Guid)).Returns(true);
            _mockProductRepo.Setup(repo => repo.GetAllProducts(options)).Returns(mockProducts);
            _mockProductRepo.Setup(repo => repo.GetOneProduct(FashionProduct1Guid)).Returns(mockProduct1);
            _mockProductRepo.Setup(repo => repo.CheckProductExist(FashionProduct1Guid)).Returns(true);

            _productService = new ProductService(_mockProductRepo.Object, _mapper, _mockCategoryRepo.Object);
        }

        [Fact]
        public void ProductService_DeleteProduct_ShouldDeleteRightProduct()
        {
            var result = _productService.DeleteProduct(FashionProduct2Guid);

            Assert.True(result);
        }

        [Fact]
        public void ProductService_GetAllProducts_ReturnsAllProducts()
        {
            var result = _productService.GetAllProducts(options);
            result.Should().NotBeEmpty().And.HaveCount(2);
        }

        [Fact]
        public void ProductService_GetOneProduct_ReturnsTheRightProduct()
        {
            var result = _productService.GetOneProduct(FashionProduct1Guid);

            result.Should().NotBeNull();
            result.Should().BeOfType(typeof(ProductReadDTO));
        }

        [Fact]
        public void ProductService_CreateNewProduct_ReturnsTheCreatedProduct()
        {
            _mockCategoryRepo.Setup(repo => repo.CheckCategoryExist(Category1Guid)).Returns(true);
            _mockProductRepo.Setup(repo => repo.CreateNewProduct(It.IsAny<Product>())).Returns(mockProduct3);

            var result = _productService.CreateNewProduct(product3CreateDTO);

            Assert.Equal(result.Title, mockProduct3.Title);

            _mockCategoryRepo.Verify(repo => repo.CheckCategoryExist(Category1Guid), Times.Once);
            _mockProductRepo.Verify(repo => repo.CreateNewProduct(It.IsAny<Product>()), Times.Once);
        }

        [Fact]
        public void ProductService_UpdateProduct_ShouldReturnTrue()
        {
            _mockProductRepo.Setup(repo => repo.UpdateProduct(It.IsAny<Guid>(), It.IsAny<Product>())).Returns(true);
            Assert.True(_productService.UpdateProduct(mockProduct3.Id, product3UpdateDTO));
        }
    }
}