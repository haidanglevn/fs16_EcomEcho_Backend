using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;

namespace EcommerceAPI.Core.src.Abstraction
{
    public interface IAddressRepo
    {
        Address CreateNewAddress(Address address);
        IEnumerable<Address> GetAllAddresses(GetAllParams options);
        IEnumerable<Address> GetAddressesByUserId(Guid userId);
        Address GetOneAddress(Guid addressId);
        bool UpdateAddress(Guid addressId, Address address);
        bool DeleteAddress(Guid addressId);
    }
}