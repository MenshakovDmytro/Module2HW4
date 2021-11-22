using SafariPark.Models.Enums;

namespace SafariPark.Models.Coldblooded.Reptiles
{
    public class Turtle : Reptile
    {
        public override ReptileGroup ReptileGroup => ReptileGroup.Turtles;

        public override int AverageAnabiosisDurationInMonths => 4;

        public override string Species => nameof(Turtle);

        public override string Genus => nameof(Reptile);
    }
}