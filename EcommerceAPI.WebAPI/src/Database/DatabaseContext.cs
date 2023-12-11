using EcommerceAPI.Core.src.Entity;

namespace EcommerceAPI.WebAPI.src.Database
{
    public class DatabaseContext
    {
        public List<User> Users { get; set; }
        public DatabaseContext()
        {
            Users = new List<User>{
                new() {LastName = "Ben", FirstName="White", Email= "white@mail.com", Password = "something"},
                new() {LastName = "Aaron", FirstName="Ramsdale", Email= "aaron@mail.com", Password = "something"},
                new() {LastName = "Dang", FirstName="Le", Email= "dang@mail.com", Password = "something"},
                new() {LastName = "Declan", FirstName="Rice", Email= "rice@mail.com", Password = "something"},
            };
        }

    }
}