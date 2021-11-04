using System;
using System.Collections.Generic;

namespace Spg.Meixner.Pos.Aquarium.Angular.Models
{
    public class Prerequisites
    {
        public Guid Id { get; init; }
        public string Description { get; init; }

        public IEnumerable<Organism> RequiredFor;
    }
}