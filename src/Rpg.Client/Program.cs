using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using Rpg.Client.State;

namespace Rpg.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
                services.AddSingleton<AlchemyState>();
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
