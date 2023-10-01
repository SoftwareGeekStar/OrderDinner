namespace OrderDinner.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Register(string firstName, string lastName, string email, string Password);
    AuthenticationResult Login( string email, string Password);
}