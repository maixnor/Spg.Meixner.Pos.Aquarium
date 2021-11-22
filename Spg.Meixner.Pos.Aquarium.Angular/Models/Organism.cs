using System;
using System.Collections.Generic;

namespace Spg.Meixner.Pos.Aquarium.Angular.Models
{
    public class Organism
    {
        public Guid Id { get; init; }
        public string Color { get; init; }
        public int SpaceInCcm { get; init; }
        public int TemperatureMin { get; init; }
        public int TemperatureMax { get; init; }
        public Species Species { get; init; }
        public Region Region { get; init; }

        public IEnumerable<Prerequisite> Prerequisites;
        public IEnumerable<Food> Foods;
        public IEnumerable<Tank> Tanks;
        public IEnumerable<Organism> Beneficial;
        public IEnumerable<Organism> Malevolent;
    }
}