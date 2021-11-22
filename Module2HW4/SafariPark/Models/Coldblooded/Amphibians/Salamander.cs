using SafariPark.Models.Enums;

namespace SafariPark.Models.Coldblooded.Amphibians
{
    public class Salamander : Amphibian
    {
        public override AmphibianGroup AmphibianGroup => AmphibianGroup.Tailed;

        public override int AverageAnabiosisDurationInMonths => 4;

        public override string Species => nameof(Salamander);

        public override string Genus => nameof(Amphibian);
    }
}
