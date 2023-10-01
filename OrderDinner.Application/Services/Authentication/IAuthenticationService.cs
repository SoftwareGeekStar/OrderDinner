namespace OrderDinner.Application.Service.Authentication;

public interface IAuthenticationService
{
    AuthenticationResponse Login(LoginRequest request);
    AuthenticationResponse Response(RegisterRequest request);
}