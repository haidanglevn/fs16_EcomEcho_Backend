using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Parameter;

namespace EcommerceAPI.Business.src.Abstraction
{
    public interface IAddressService
    {
        AddressReadDTO CreateNewAddress(AddressCreateDTO address);
        IEnumerable<AddressReadDTO> GetAllAddresses(GetAllParams options);
        IEnumerable<AddressReadDTO> GetAddressesByUserId(Guid userId);
        AddressReadDTO GetOneAddress(Guid addressId);
        bool UpdateAddress(Guid addressId, AddressUpdateDTO address);
        bool DeleteAddress(Guid addressId);

    }
}