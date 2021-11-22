using System;
using System.Collections;
using SafariPark.Models;
using SafariPark.Services.Abstractions;

namespace SafariPark.Services
{
    public class SafariParkService : ISafariParkService
    {
        private Animal[] _animals;
        private AnimalSection[] _animalSections;

        public SafariParkService()
        {
            _animals = new Animal[0];
            _animalSections = InitBaseSections();
        }

        public void DistributeAnimalsBySections(Animal[] animals)
        {
            var totalLength = _animals.Length + animals.Length;
            var position = _animals.Length;
            Array.Resize(ref _animals, totalLength);
            animals.CopyTo(_animals, position);

            for (var i = 0; i < animals.Length; i++)
            {
                switch (animals[i].Genus)
                {
                    case "Amphibian":
                        AddAnimalToSection("Amphibians", animals[i]);
                        break;
                    case "Reptile":
                        AddAnimalToSection("Reptiles", animals[i]);
                        break;
                    case "Bird":
                        AddAnimalToSection("Birds", animals[i]);
                        break;
                    case "Mammal":
                        AddAnimalToSection("Mammals", animals[i]);
                        break;
                }
            }
        }

        public void AddAnimalToSection(string sectionName, Animal animal)
        {
            for (var i = 0; i < _animalSections.Length; i++)
            {
                if (_animalSections[i].Name.Equals(sectionName))
                {
                    var animalsInSection = _animalSections[i].Animals;
                    var position = animalsInSection.Length;
                    Array.Resize(ref animalsInSection, animalsInSection.Length + 1);
                    animalsInSection[position] = animal;
                    _animalSections[i].Animals = animalsInSection;
                    break;
                }
            }
        }

        public AnimalSection GetSectionByName(string sectionName)
        {
            switch (sectionName)
            {
                case "Amphibians":
                    return _animalSections[0];
                case "Reptiles":
                    return _animalSections[1];
                case "Birds":
                    return _animalSections[2];
                case "Mammals":
                    return _animalSections[3];
                default:
                    return null;
            }
        }

        public void SortAnimals(AnimalSection animalSection, IComparer comparer)
        {
            Array.Sort(animalSection.Animals, comparer);
        }

        public int CountDifferentAnimalsInSection(AnimalSection animalSection)
        {
            var animals = animalSection.Animals;
            var count = 0;
            for (var i = 0; i < animals.Length; i++)
            {
                var isDuplicate = false;
                for (var j = 0; j < i; j++)
                {
                    if (animals[i].Species.Equals(animals[j].Species))
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    count++;
                }
            }

            return count;
        }

        private AnimalSection[] InitBaseSections()
        {
            var sections = new AnimalSection[4];
            sections[0] = new AnimalSection() { Name = "Amphibians", Square = 50, Animals = new Animal[0] };
            sections[1] = new AnimalSection() { Name = "Reptiles", Square = 60, Animals = new Animal[0] };
            sections[2] = new AnimalSection() { Name = "Birds", Square = 30, Animals = new Animal[0] };
            sections[3] = new AnimalSection() { Name = "Mammals", Square = 80, Animals = new Animal[0] };
            return sections;
        }
    }
}