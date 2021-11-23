using SafariPark.Models.Enums;

namespace SafariPark.Models.Coldblooded.Reptiles
{
    public abstract class Reptile : ColdBlooded
    {
        public abstract ReptileGroup ReptileGroup { get; }
    }
}