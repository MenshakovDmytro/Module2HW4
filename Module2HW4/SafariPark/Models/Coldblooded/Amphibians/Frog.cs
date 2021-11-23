using SafariPark.Models.Enums;

namespace SafariPark.Models.Coldblooded.Amphibians
{
    public class Frog : Amphibian
    {
        public override AmphibianGroup AmphibianGroup => AmphibianGroup.Tailless;

        public override int AverageAnabiosisDurationInMonths => 4;

        public override string Species => nameof(Frog);

        public override string Genus => nameof(Amphibian);
    }
}