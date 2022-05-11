using System;
using MarsRover.Application.DI;
using MarsRover.Bussiness.Interfaces;
using MarsRover.Bussiness.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MarsRover.Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var services=host.Services;
            var _commandHandler = services.GetService<ICommandHandler>();
            var input = GetInput();
            _commandHandler.Build(input);
            Console.WriteLine("Command Execution starting...");
            _commandHandler.Execute();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.UseRegisterServices();
                });

        static string GetInput()
        {
            Console.WriteLine("Plateau and Rover Parameters will be taken until empty line");

            var inputString = string.Empty;
            while (true)
            {
                string line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                    break;
                inputString = $"{inputString} | {line}";
            }

            return inputString;
        }
    }
}
