using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ConsoleApplication.TemplateOfUsingDI
{
    public class App
    {
        private readonly ILogger<App> _logger;
        private readonly IConfiguration _config;
        private readonly IHttpClientFactory _httpClientFactory;

        public App(ILogger<App> logger, IConfiguration config, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _config = config;
            _httpClientFactory = httpClientFactory;
        }

        public async Task Run()
        {
            await Task.WhenAll(new List<Task> { FirstAction(), SecondAction() });
        }

        public async Task FirstAction()
        {
            await Task.Run(() => { });
        }

        public async Task SecondAction()
        {
            await Task.Run(() => { });
        }
    }
}
