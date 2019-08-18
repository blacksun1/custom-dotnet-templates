using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Blacksun1.FuncDI;

[assembly: FunctionsStartup(typeof(Startup))]
namespace Blacksun1.FuncDI
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var services = builder.Services;

            services.AddHttpClient();

            services.AddLogging();
        }
    }
}
