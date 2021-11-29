using System;
using System.Collections.Generic;

namespace Spg.Meixner.Pos.Aquarium.Angular.Models
{
    public class Organism
    {
        public Guid Id { get; init; }
        public string Color { get; init; } = default!;
        public int SpaceInCcm { get; init; } = default!;
        public int TemperatureMin { get; init; } = default!;
        public int TemperatureMax { get; init; } = default!;
        public Species Species { get; init; } = default!;
        public Region Region { get; init; } = default!;

        public IEnumerable<Prerequisite> Prerequisites = new List<Prerequisite>();
        public IEnumerable<Food> Foods = new List<Food>();
        public IEnumerable<Tank> Tanks = new List<Tank>();
        public IEnumerable<Organism> Beneficial = new List<Organism>();
        public IEnumerable<Organism> Malevolent = new List<Organism>();
    }
}