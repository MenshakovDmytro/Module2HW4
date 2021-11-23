using SafariPark.Models.Enums;

namespace SafariPark.Models.Warmblooded.Mammals
{
    public class Kangaroo : Mammal
    {
        public override MammalGroup MammalGroup => MammalGroup.Marsupials;

        public override ThermoregulationType ThermoregulationType => ThermoregulationType.Physical;

        public override string Species => nameof(Kangaroo);

        public override string Genus => nameof(Mammal);
    }
}