using Microsoft.AspNetCore.Mvc;
using OrderDinner.Contracts.Authentication;

namespace OrderDinner.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        return Ok(request);
    }

    [HttpPost("Login")]
    public IActionResult Login(LoginRequest request)
    {
        return Ok(request);
    }
}