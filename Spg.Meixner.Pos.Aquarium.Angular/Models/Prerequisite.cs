using System;
using System.Collections.Generic;

namespace Spg.Meixner.Pos.Aquarium.Angular.Models
{
    public class Prerequisite
    {
        public Guid Id { get; init; }
        public string Description { get; init; } = string.Empty;

        public IEnumerable<Organism> RequiredFor = new List<Organism>();
    }
}