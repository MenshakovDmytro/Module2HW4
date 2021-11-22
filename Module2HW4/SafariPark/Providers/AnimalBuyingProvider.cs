using SafariPark.Models;
using SafariPark.Models.Coldblooded.Amphibians;
using SafariPark.Models.Coldblooded.Reptiles;
using SafariPark.Models.Warmblooded.Birds;
using SafariPark.Models.Warmblooded.Mammals;
using SafariPark.Providers.Abstractions;

namespace SafariPark.Providers
{
    public class AnimalBuyingProvider : IAnimalBuyingProvider
    {
        public Animal[] BuyAnimals()
        {
            var animals = new Animal[6];
            animals[0] = new Salamander() { Name = "Heidi", Age = 4 };
            animals[1] = new Turtle() { Name = "Fiddle", Age = 30 };
            animals[2] = new Bear() { Name = "Bean", Age = 10 };
            animals[3] = new Emu() { Name = "Berry", Age = 5 };
            animals[4] = new Parrot() { Name = "Stitch", Age = 2 };
            animals[5] = new Emu() { Name = "Kendrick", Age = 6 };
            return animals;
        }
    }
}