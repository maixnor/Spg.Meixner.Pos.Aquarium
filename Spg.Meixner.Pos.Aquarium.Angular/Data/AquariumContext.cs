using Microsoft.EntityFrameworkCore;
using Spg.Meixner.Pos.Aquarium.Angular.Models;

namespace Spg.Meixner.Pos.Aquarium.Angular.Data
{
    public class AquariumContext : DbContext
    {
        public DbSet<Area> Areas { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Organism> Organisms { get; set; }
        public DbSet<Prerequisite> Prerequisites { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Tank> Tanks { get; set; }
    }
}