using SafariPark.Models.Enums;

namespace SafariPark.Models.Warmblooded.Birds
{
    public class Emu : Bird
    {
        public override bool CanFly => false;

        public override ThermoregulationType ThermoregulationType => ThermoregulationType.Physical;

        public override string Species => nameof(Emu);

        public override string Genus => nameof(Bird);
    }
}