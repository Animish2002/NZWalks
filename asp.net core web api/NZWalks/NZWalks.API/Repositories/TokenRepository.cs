using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NZWalks.API.Repositories
{
    public class TokenRepository : ITokenRepository
    {
        private IConfiguration configration;

        public TokenRepository(IConfiguration configration) 
        {
            this.configration = configration;
        }
        public string CreateJWTToken(IdentityUser user, List<string> roles)
        {
            //create claims
            var claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Email, user.Email));

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configration["Jwt:Key"]));

            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


             var token = new JwtSecurityToken(
             configration["Jwt:Issuer"],
             configration["Jwt:Audience"],
             claims,
             expires: DateTime.Now.AddMinutes(15), // Corrected parenthesis placement
             signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token); 
        }
    }
}
