using OrderDinner.Application.Common.Interfaces.Authentication;
namespace OrderDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTockenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTockenGenerator)
    {
        _jwtTockenGenerator = jwtTockenGenerator;
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string Password)
    {
        //Check if user already exists

        //Create user (Generate unique ID)

        //Create Jwt token

        Guid userId = Guid.NewGuid();
        
        var token = _jwtTockenGenerator.GenerateToken(userId, firstName, lastName);

        return new AuthenticationResult(
            userId,
            firstName,
            lastName,
            email,
            token
        );
    }

    public AuthenticationResult Login(string email, string Password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            "firstName",
            "lastName",
            email,
            "token"
        );
    }
}

