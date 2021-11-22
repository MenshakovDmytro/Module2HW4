using SafariPark.Models;

namespace SafariPark.Providers.Abstractions
{
    public interface IAnimalBuyingProvider
    {
        public Animal[] BuyAnimals();
    }
}