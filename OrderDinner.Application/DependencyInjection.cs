using Microsoft.Extensions.DependencyInjection;
using OrderDinner.Application.Services.Authentication;

namespace OrderDinner.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
            services.AddScoped<IAuthenticationService, AuthenticationService> ();
            return services;
    }
}