using System;
using SafariPark.Models;

namespace SafariPark.Helper
{
    public static class AnimalSectionExtension
    {
        public static Animal[] FindAnimalsByGenus(this AnimalSection animalSection, string genus)
        {
            var animalsInSection = animalSection.Animals;
            var sameSpeciesAnimals = new Animal[animalsInSection.Length];
            var size = 0;
            for (var i = 0; i < animalsInSection.Length; i++)
            {
                if (animalsInSection[i].Genus.Equals(genus))
                {
                    sameSpeciesAnimals[size++] = animalsInSection[i];
                }
            }

            if (size != animalsInSection.Length)
            {
                Array.Resize(ref sameSpeciesAnimals, size);
            }

            return sameSpeciesAnimals;
        }
    }
}