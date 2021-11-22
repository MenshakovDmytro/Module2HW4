using SafariPark.Models.Enums;

namespace SafariPark.Models.Warmblooded.Mammals
{
    public class Bear : Mammal
    {
        public override MammalGroup MammalGroup => MammalGroup.Placenta;

        public override ThermoregulationType ThermoregulationType => ThermoregulationType.Physical;

        public override string Species => nameof(Bear);

        public override string Genus => nameof(Mammal);
    }
}