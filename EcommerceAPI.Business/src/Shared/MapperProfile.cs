using AutoMapper;
using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Entity;

namespace EcommerceAPI.Business.src.Shared
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserReadDTO>();
            CreateMap<UserCreateDTO, User>();
        }
    }
}