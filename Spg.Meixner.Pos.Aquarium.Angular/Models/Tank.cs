using System;

namespace Spg.Meixner.Pos.Aquarium.Angular.Models
{
    public class Tank
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public int CapacityInCcm { get; init; }
    }
}