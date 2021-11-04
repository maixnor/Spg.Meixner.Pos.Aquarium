using System;

namespace Spg.Meixner.Pos.Aquarium.Angular.Models
{
    public record Organism(Guid Id, string Color, int SpaceInCcm, Range Temperatures, Species Species);
}