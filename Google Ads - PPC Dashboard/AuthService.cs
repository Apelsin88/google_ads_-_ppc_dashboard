using Google_Ads___PPC_Dashboard.Data;
using Google_Ads___PPC_Dashboard.Models;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
namespace Google_Ads___PPC_Dashboard
{
    public class AuthService
    {

        private readonly Google_Ads___PPC_DashboardContext _dbContext;

        public AuthService(Google_Ads___PPC_DashboardContext dbContext)
        {
            _dbContext = dbContext;
        }

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
            ci.AddClaim(new Claim(ClaimTypes.Email, user.Email));

            foreach (UserRole userRole in user.UserRoles)
            {
                ci.AddClaim(new Claim(ClaimTypes.Role, userRole.Role.Name));
            }

            return ci;
        }

        public async Task<ApplicationUser?> AuthenticateUser(string username, string password)
        {
            // Retrieve the user by username
            var user = await _dbContext.ApplicationUsers
                .Include(u => u.UserRoles)
                    .ThenInclude(ur => ur.Role)
                .FirstOrDefaultAsync(u => u.Username == username);

            if (user == null)
            {
                // User not found
                return null;
            }

            // Verify the password
            if (!VerifyPassword(password, user.PasswordHash))
            {
                // Password does not match
                return null;
            }

            // Authentication successful
            return user;
        }

        private bool VerifyPassword(string password, string passwordHash)
        {
            // Implement password verification here
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }

    }
}
