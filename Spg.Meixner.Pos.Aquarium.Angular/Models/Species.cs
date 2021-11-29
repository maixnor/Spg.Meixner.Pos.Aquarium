using System;

namespace Spg.Meixner.Pos.Aquarium.Angular.Models
{
    public class Species
    {

        public Guid Id { get; init; }
        public Rank Rank { get; init; } = Rank.None;
        public string Name { get; init; } = string.Empty;
        public string LatinName { get; init; } = string.Empty;
    }
}