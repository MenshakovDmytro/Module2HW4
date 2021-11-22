using SafariPark.Models.Enums;

namespace SafariPark.Models.Coldblooded.Amphibians
{
    public abstract class Amphibian : ColdBlooded
    {
        public abstract AmphibianGroup AmphibianGroup { get; }
    }
}