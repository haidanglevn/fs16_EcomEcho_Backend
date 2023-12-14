using EcommerceAPI.Business.src.DTO;

namespace EcommerceAPI.Business.src.Abstraction
{
    public interface ITokenService
    {
        public string CreateToken(UserReadDTO userReadDTO);
    }
}