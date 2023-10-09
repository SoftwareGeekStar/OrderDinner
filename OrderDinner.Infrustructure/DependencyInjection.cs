using Microsoft.Extensions.DependencyInjection;
using OrderDinner.Application.Common.Interfaces.Authentication;
using OrderDinner.Infrustructure.Authentication;

namespace OrderDinner.Infrustructure;

public static class DependencyInjections
{
    public static IServiceCollection AddInfrustructure(this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        return services;
    }
} 