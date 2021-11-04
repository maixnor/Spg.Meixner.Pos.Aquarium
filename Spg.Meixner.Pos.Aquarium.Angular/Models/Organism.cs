using System;

namespace Spg.Meixner.Pos.Aquarium.Angular.Models
{
    public class Organism
    {
        public Guid Id { get; init; }
        public string Color { get; init; }
        public int SpaceInCcm { get; init; }
        public Range Temperatures { get; init; }
        public Species Species { get; init; }
        public Region Region { get; init; }
    }
}