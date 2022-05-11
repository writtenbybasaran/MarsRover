using MarsRover.Bussiness.Interfaces;
using MarsRover.Bussiness.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MarsRover.Application.DI
{
    public static class RegisterServices
    {
        public static void UseRegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ICommandHandler, CommandHandler>();
            services.AddScoped<IPlateauBuilder, PlateauBuilder>();
            services.AddScoped<IRoverBuilder, RoverBuilder>();
        }
    }
}
