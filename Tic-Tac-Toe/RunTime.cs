using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System.IO;

namespace Tic_Tac_Toe
{
    class RunTime
    {
        static void Main()
        {
            /*
            InputEventHandler inputEventHandler = new InputEventHandler();
            Thread InputHandler = new Thread(inputEventHandler.KeyPressedCheck);
            InputHandler.Start();
            Menus.MainMenu();
            Console.ReadKey(true);
            */

            var builder = new ConfigurationBuilder();
            BuildConfig(builder);

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
                .Enrich.FromLogContext()
                .WriteTo.Debug()
                .CreateLogger();

            Log.Logger.Information("Application Starting...");

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {

                })
                .UseSerilog()
                .Build();

        }

        static void BuildConfig(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIROMENT") ?? "Produciton"}.json", optional: true)
                .AddEnvironmentVariables();
        }
    }
}  