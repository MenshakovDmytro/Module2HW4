using SafariPark.Models.Enums;

namespace SafariPark.Models.Warmblooded
{
    public abstract class WarmBlooded : Animal
    {
        public override bool BodyTemperatureDependsOnEnvironment => false;
        public abstract ThermoregulationType ThermoregulationType { get; }
    }
}