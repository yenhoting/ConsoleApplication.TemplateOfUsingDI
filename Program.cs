// See https://aka.ms/new-console-template for more information
using ConsoleApplication.TemplateOfUsingDI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = new HostBuilder()
             .ConfigureAppConfiguration((hostContext, config) =>
             {
                 config.AddJsonFile("appsettings.json", optional: true);
                 config.AddEnvironmentVariables();
             })
            .ConfigureServices((hostContext, services) =>
            {
                services.AddHttpClient();
                services.AddTransient<App>();
            });

builder.Build().Services.GetRequiredService<App>().Run().Wait();

