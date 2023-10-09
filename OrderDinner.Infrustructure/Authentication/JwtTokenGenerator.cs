using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using OrderDinner.Application.Common.Interfaces.Authentication;

namespace OrderDinner.Infrustructure.Authentication;

public class JwtTokenGenerator : IJwtTokenGenerator
{
	public string GenerateToken(Guid userId, string firstName, string lastName)
	{
		var signingCredentials = new SigningCredentials(
			new SymmetricSecurityKey(
				Encoding.UTF8.GetBytes("super-secret-key")),
			SecurityAlgorithms.HmacSha256);
	  
		var claims = new []
		{
			new Claim(JwtRegisteredClaimNames.Sub, firstName + " " + lastName),
			new Claim(JwtRegisteredClaimNames.GivenName, firstName),
			new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
			new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
		};

		var SecurityToken = new JwtSecurityToken(
			 issuer: "OrderDinner",
			 expires: DateTime.Now.AddDays(1),
			 claims : claims,
			 signingCredentials : signingCredentials);

		return new JwtSecurityTokenHandler().WriteToken(SecurityToken);
		
	}
}