using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            services.AddSingleton<IPlateauBuilder, PlateauBuilder>();
            services.AddScoped<IRoverBuilder, RoverBuilder>();
        }
    }
}
