using SafariPark.Models.Enums;

namespace SafariPark.Models.Warmblooded.Mammals
{
    public abstract class Mammal : WarmBlooded
    {
        public abstract MammalGroup MammalGroup { get; }
    }
}