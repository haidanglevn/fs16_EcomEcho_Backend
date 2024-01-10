using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;
using EcommerceAPI.WebAPI.src.Database;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.WebAPI.src.Repository
{
    public class AddressRepo : IAddressRepo
    {
        private DbSet<Address> _addresses;
        private DatabaseContext _database;
        public AddressRepo(DatabaseContext database)
        {
            _database = database;
            _addresses = database.Addresses;
        }
        public Address CreateNewAddress(Address address)
        {
            try
            {
                _addresses.Add(address);
                _database.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Error creating new order: " + e.Message.ToString());
            }
            return address;
        }

        public bool DeleteAddress(Guid addressId)
        {
            var address = _addresses.Find(addressId);
            if (address != null)
            {
                _addresses.Remove(address);
                _database.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Address> GetAddressesByUserId(Guid userId)
        {
            return _addresses.AsNoTracking().Where(a => a.UserId == userId);
        }

        public IEnumerable<Address> GetAllAddresses(GetAllParams options)
        {
            throw new NotImplementedException();
        }

        public Address? GetOneAddress(Guid addressId)
        {
            return _addresses.FirstOrDefault(a => a.Id == addressId);
        }

        public bool UpdateAddress(Guid addressId, Address address)
        {
            throw new NotImplementedException();
        }
    }
}