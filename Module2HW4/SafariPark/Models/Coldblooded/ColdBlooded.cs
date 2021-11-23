namespace SafariPark.Models.Coldblooded
{
    public abstract class ColdBlooded : Animal
    {
        public override bool BodyTemperatureDependsOnEnvironment => true;
        public abstract int AverageAnabiosisDurationInMonths { get; }
    }
}
