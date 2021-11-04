using System;

namespace Spg.Meixner.Pos.Aquarium.Angular.Models
{
    public class Species
    {

        public Guid Id { get; init; }
        public Rank Rank { get; init; }
        public string Name { get; init; }
        public string LatinName { get; init; }
    }
}