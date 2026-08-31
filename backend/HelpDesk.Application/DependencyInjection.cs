using HelpDesk.Application.Interfaces;
using HelpDesk.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HelpDesk.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddScoped<ITicketService, TicketService>();
        services.AddScoped<IUserService, UserService>();

        return services;
    }
}