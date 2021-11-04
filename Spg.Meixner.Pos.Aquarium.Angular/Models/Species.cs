using System;

namespace Spg.Meixner.Pos.Aquarium.Angular.Models
{
    public record Species(Guid Id, Rank Rank, string Name, string LatinName);
}