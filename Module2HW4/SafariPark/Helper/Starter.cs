using SafariPark.Services.Abstractions;

namespace SafariPark.Helper
{
    public class Starter
    {
        private readonly IAnimalBuyingService _animalBuyingService;
        private readonly ISafariParkService _safariParkService;

        public Starter(IAnimalBuyingService animalBuyingService, ISafariParkService safariParkService)
        {
            _animalBuyingService = animalBuyingService;
            _safariParkService = safariParkService;
        }

        public void Run()
        {
            var comparer = new AnimalComparer();
            var animals = _animalBuyingService.BuyAnimals();
            _safariParkService.DistributeAnimalsBySections(animals);
            var animalSection = _safariParkService.GetSectionByName("Birds");
            _safariParkService.SortAnimals(animalSection, comparer);
            _safariParkService.CountDifferentAnimalsInSection(animalSection);
            var sameSpeciesAniumal = animalSection.FindAnimalsByGenus("Bird");
        }
    }
}