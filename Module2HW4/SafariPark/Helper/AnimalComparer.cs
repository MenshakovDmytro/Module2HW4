using System.Collections;
using SafariPark.Models;

namespace SafariPark.Helper
{
    public class AnimalComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var firstAnimal = x as Animal;
            var secondAnimal = y as Animal;
            return firstAnimal.Age.CompareTo(secondAnimal.Age);
        }
    }
}