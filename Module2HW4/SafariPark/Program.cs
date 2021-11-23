using Microsoft.Extensions.DependencyInjection;
using SafariPark.Helper;
using SafariPark.Providers;
using SafariPark.Providers.Abstractions;
using SafariPark.Services;
using SafariPark.Services.Abstractions;

namespace SafariPark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var start = new ServiceCollection()
                .AddTransient<IAnimalBuyingProvider, AnimalBuyingProvider>()
                .AddTransient<IAnimalBuyingService, AnimalBuyingService>()
                .AddSingleton<ISafariParkService, SafariParkService>()
                .AddTransient<Starter>()
                .BuildServiceProvider();

            var starter = start.GetService<Starter>();
            starter.Run();
        }
    }
}