namespace EcommerceAPI.Business.src.Abstraction
{
    public interface IPasswordHasher
    {
        string HashPassword(string password);
        bool VerifyPassword(string hashedPassword, string userInputPassword);
    }
}
