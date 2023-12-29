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
            CreateMap<UserCreateAdminDTO, User>();
            CreateMap<UserUpdateDTO, User>()
                .ForMember(dest => dest.FirstName, opt => opt.Condition(src => src.FirstName != null))
                .ForMember(dest => dest.LastName, opt => opt.Condition(src => src.LastName != null))
                .ForMember(dest => dest.Email, opt => opt.Condition(src => src.Email != null))
                // Add similar lines for other properties that are optional in the update
                .ForMember(dest => dest.Role, opt => opt.Ignore()); // Explicitly ignore Role
            CreateMap<User, UserReadNoAddressDTO>();
            CreateMap<User, UserReadSimpleDTO>();

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

            // Order
            CreateMap<Order, OrderReadDTO>();
            CreateMap<OrderCreateDTO, Order>();
            CreateMap<OrderUpdateDTO, Order>().ForAllMembers(opt => opt.Condition((src, dest, member) => member != null));
            // OrderItem
            CreateMap<OrderItemCreateDTO, OrderItem>();
            CreateMap<OrderItem, OrderItemReadDTO>();
        }
    }
}