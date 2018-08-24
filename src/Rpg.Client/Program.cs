using Microsoft.AspNetCore.Blazor.Hosting;

namespace Rpg.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }
        public static IWebAssemblyHost BuildWebHost(string[] args) =>
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                .UseBlazorStartup<Startup>()
                .Build();
    }
}
