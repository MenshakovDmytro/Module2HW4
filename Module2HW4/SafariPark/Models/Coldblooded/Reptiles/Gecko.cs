using SafariPark.Models.Enums;

namespace SafariPark.Models.Coldblooded.Reptiles
{
    public class Gecko : Reptile
    {
        public override ReptileGroup ReptileGroup => ReptileGroup.Scaly;

        public override int AverageAnabiosisDurationInMonths => 2;

        public override string Species => nameof(Gecko);

        public override string Genus => nameof(Reptile);
    }
}