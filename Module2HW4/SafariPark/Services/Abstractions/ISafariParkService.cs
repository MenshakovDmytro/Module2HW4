using System.Collections;
using SafariPark.Models;

namespace SafariPark.Services.Abstractions
{
    public interface ISafariParkService
    {
        public void DistributeAnimalsBySections(Animal[] animals);
        public void AddAnimalToSection(string sectionName, Animal animal);
        public AnimalSection GetSectionByName(string sectionName);
        public void SortAnimals(AnimalSection animalSection, IComparer comparer);
        public int CountDifferentAnimalsInSection(AnimalSection animalSection);
    }
}