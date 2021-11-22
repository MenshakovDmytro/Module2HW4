namespace SafariPark.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract string Species { get; }
        public abstract bool BodyTemperatureDependsOnEnvironment { get; }
        public abstract string Genus { get; }
    }
}