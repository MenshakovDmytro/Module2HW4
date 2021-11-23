using SafariPark.Models;

namespace SafariPark.Services.Abstractions
{
    public interface IAnimalBuyingService
    {
        public Animal[] BuyAnimals();
    }
}