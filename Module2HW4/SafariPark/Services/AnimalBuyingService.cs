using SafariPark.Models;
using SafariPark.Providers.Abstractions;
using SafariPark.Services.Abstractions;

namespace SafariPark.Services
{
    public class AnimalBuyingService : IAnimalBuyingService
    {
        private readonly IAnimalBuyingProvider _animalBuyingProvider;

        public AnimalBuyingService(IAnimalBuyingProvider animalBuyingProvider)
        {
            _animalBuyingProvider = animalBuyingProvider;
        }

        public Animal[] BuyAnimals()
        {
            return _animalBuyingProvider.BuyAnimals();
        }
    }
}