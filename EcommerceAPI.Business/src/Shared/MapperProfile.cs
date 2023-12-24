using AutoMapper;
using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Entity;

namespace EcommerceAPI.Business.src.Shared
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // User
            CreateMap<User, UserReadDTO>();
            CreateMap<UserCreateDTO, User>();
            CreateMap<UserUpdateDTO, User>().ForAllMembers(opt => opt.Condition((src, dest, member) => member != null));
            CreateMap<User, UserReadNoAddressDTO>();

            // Product
            CreateMap<Product, ProductReadDTO>();
            CreateMap<ProductCreateDTO, Product>();
            CreateMap<ProductUpdateDTO, Product>().ForAllMembers(opt => opt.Condition((src, dest, member) => member != null));
            CreateMap<Product, ProductReadSimpleDTO>();

            // Review
            CreateMap<Review, ReviewReadDTO>();
            CreateMap<ReviewCreateDTO, Review>();
            CreateMap<ReviewUpdateDTO, Review>().ForAllMembers(opt => opt.Condition((src, dest, member) => member != null));

            // Image
            CreateMap<Image, ImageReadDTO>();
            CreateMap<ImageCreateDTO, Image>();
            CreateMap<ImageUpdateDTO, Image>().ForAllMembers(opt => opt.Condition((src, dest, member) => member != null));

            // Variant
            CreateMap<VariantCreateDTO, Variant>();

            // Category
            CreateMap<Category, CategoryReadDTO>();
            CreateMap<CategoryCreateDTO, Category>();
            CreateMap<CategoryUpdateDTO, Category>();

            // Address
            CreateMap<Address, AddressReadDTO>();
        }
    }
}