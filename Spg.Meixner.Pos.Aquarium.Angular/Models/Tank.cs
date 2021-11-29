using System;

namespace Spg.Meixner.Pos.Aquarium.Angular.Models
{
    public class Tank
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public int CapacityInCcm { get; init; } = default!;
    }
}