using Microsoft.EntityFrameworkCore;
using Spg.Meixner.Pos.Aquarium.Angular.Models;

namespace Spg.Meixner.Pos.Aquarium.Angular.Data
{
    public class AquariumContext : DbContext
    {
        public DbSet<Area> Areas { get; set; } = default!;
        public DbSet<Food> Foods { get; set; } = default!;
        public DbSet<Organism> Organisms { get; set; } = default!;
        public DbSet<Prerequisite> Prerequisites { get; set; }  = default!;
        public DbSet<Species> Species { get; set; } = default!;
        public DbSet<Tank> Tanks { get; set; } = default!;

        public AquariumContext(DbContextOptions<AquariumContext> options) 
            : base(options) { }
    }
}