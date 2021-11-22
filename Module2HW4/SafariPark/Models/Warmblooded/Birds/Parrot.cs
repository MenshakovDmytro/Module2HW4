using SafariPark.Models.Enums;

namespace SafariPark.Models.Warmblooded.Birds
{
    public class Parrot : Bird
    {
        public override bool CanFly => true;

        public override ThermoregulationType ThermoregulationType => ThermoregulationType.Physical;

        public override string Species => nameof(Parrot);

        public override string Genus => nameof(Bird);
    }
}