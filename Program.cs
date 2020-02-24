using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using TrckFit.Web.Services;

namespace TrckFit.Web
{
    public class Program
    {
        public static async Task Main(string[] args) => 
            await WebAssemblyHostBuilder.CreateDefault(args)
                .Configure()
                .Build()
                .RunAsync();
    }

    internal static class ProgramExtensions
    {
        public static WebAssemblyHostBuilder Configure(this WebAssemblyHostBuilder builder)
        {
            builder.RootComponents.Add<App>("app");
            builder.Services.AddTransient<IDataService, DataService>();
            return builder;
        }
    }
}