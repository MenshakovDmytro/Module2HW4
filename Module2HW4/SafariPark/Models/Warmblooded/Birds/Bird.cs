namespace SafariPark.Models.Warmblooded.Birds
{
    public abstract class Bird : WarmBlooded
    {
        public abstract bool CanFly { get; }
    }
}