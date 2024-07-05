using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Turizm_Yonetim_Sistemi.BusinessLayer.Abstract;

namespace Turizm_Yonetim_Sistemi.BusinessLayer.Concrete.Security
{
    public class TokenHandler : ITokenHandler
    {
        public readonly IConfiguration _configuration;

        public TokenHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Token CreateToken(IdentityUser user)
        {
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:SecurityKey"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.UserName)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"]
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var SecurityToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(SecurityToken);

            byte[] numbers = new byte[32];
            using RandomNumberGenerator random = RandomNumberGenerator.Create();
            random.GetBytes(numbers);            


            return new Token
            {
                AccessToken = token,
                Expiration = tokenDescriptor.Expires.Value,
                RefreshToken = Convert.ToBase64String(numbers)
            };
        }
    }
}
