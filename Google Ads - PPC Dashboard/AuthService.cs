using Google_Ads___PPC_Dashboard.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
namespace Google_Ads___PPC_Dashboard
{
    public class AuthService
    {
        public string Create(ApplicationUser user)
        {
            var handler = new JwtSecurityTokenHandler();

            var privateKey = Encoding.UTF8.GetBytes(Configuration.PrivateKey);

            var credentials = new SigningCredentials(new SymmetricSecurityKey(privateKey),SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                SigningCredentials = credentials,
                Expires = DateTime.UtcNow.AddHours(1),
                Subject = GenerateClaims(user)
            };

            var token = handler.CreateToken(tokenDescriptor);
            return handler.WriteToken(token);
        }

        private static ClaimsIdentity GenerateClaims(ApplicationUser user)
        {
            var ci = new ClaimsIdentity();

            ci.AddClaim(new Claim("id", user.Id.ToString()));
            ci.AddClaim(new Claim(ClaimTypes.Name, user.Username));
            ci.AddClaim(new Claim(ClaimTypes.GivenName, user.FirstName));
            ci.AddClaim(new Claim(ClaimTypes.Email, user.Email));

            foreach (UserRole userRole in user.UserRoles)
            {
                ci.AddClaim(new Claim(ClaimTypes.Role, userRole.Role.Name));
            }

            return ci;
        }
        
    }
}
