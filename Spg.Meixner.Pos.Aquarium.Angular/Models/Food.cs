using System;
using System.Collections.Generic;

namespace Spg.Meixner.Pos.Aquarium.Angular.Models
{
    public class Food
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public bool IsLive { get; init; } = false;

        public IEnumerable<Organism> Predators = new List<Organism>();
    }
}