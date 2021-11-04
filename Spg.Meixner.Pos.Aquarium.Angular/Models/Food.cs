using System;
using System.Collections.Generic;

namespace Spg.Meixner.Pos.Aquarium.Angular.Models
{
    public class Food
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public bool IsLive { get; init; }

        public IEnumerable<Organism> Predators;
    }
}