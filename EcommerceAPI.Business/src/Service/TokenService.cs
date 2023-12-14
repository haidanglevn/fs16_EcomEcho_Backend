using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace EcommerceAPI.Business.src.Service
{
    public class TokenService : ITokenService
    {
        private IConfiguration _configuration;
        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string CreateToken(UserReadDTO userReadDTO)
        {
            List<Claim> claims = new()
            {
                new Claim("userId", userReadDTO.Id.ToString()),
                new Claim(ClaimTypes.Email, userReadDTO.Email),
                new Claim(ClaimTypes.Role, userReadDTO.Role.ToString()),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("Jwt:Token").Value!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(10),
                signingCredentials: creds
            );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }
    }
}

// Youtube tutorial: https://www.youtube.com/watch?v=UwruwHl3BlU by Patrick God