using AutoMapper;
using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;

namespace EcommerceAPI.Business.src.Service
{
    public class AddressService : IAddressService
    {
        private IAddressRepo _addressRepo;
        private IUserRepo _userRepo;
        private IMapper _mapper;
        public AddressService(IAddressRepo addressRepo, IMapper mapper, IUserRepo userRepo)
        {
            _addressRepo = addressRepo;
            _userRepo = userRepo;
            _mapper = mapper;
        }
        public AddressReadDTO CreateNewAddress(AddressCreateDTO addressCreateDTO)
        {
            var isUserExist = _userRepo.CheckUserExist(addressCreateDTO.UserId);
            if (isUserExist)
            {
                var result = _addressRepo.CreateNewAddress(_mapper.Map<AddressCreateDTO, Address>(addressCreateDTO));
                return _mapper.Map<Address, AddressReadDTO>(result);
            }
            else
            {
                throw new Exception("Invalid User Id, please check again.");
            }
        }

        public bool DeleteAddress(Guid addressId)
        {
            return _addressRepo.DeleteAddress(addressId);
        }

        public IEnumerable<AddressReadDTO> GetAddressesByUserId(Guid userId)
        {
            return _addressRepo.GetAddressesByUserId(userId).Select(a => _mapper.Map<Address, AddressReadDTO>(a));
        }

        public IEnumerable<AddressReadDTO> GetAllAddresses(GetAllParams options)
        {
            throw new NotImplementedException();
        }

        public AddressReadDTO? GetOneAddress(Guid addressId)
        {
            var address = _addressRepo.GetOneAddress(addressId);
            if (address is not null)
            {
                return _mapper.Map<Address, AddressReadDTO>(address);
            }
            else
            {
                return null;
            }
        }

        public bool UpdateAddress(Guid addressId, AddressUpdateDTO address)
        {
            throw new NotImplementedException();
        }
    }
}