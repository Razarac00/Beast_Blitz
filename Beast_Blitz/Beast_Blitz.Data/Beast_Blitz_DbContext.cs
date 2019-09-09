using Microsoft.EntityFrameworkCore;

namespace Beast_Blitz.Data
{
    public class Beast_Blitz_DbContext : DbContext
    {
        // public DbSet<User> Users { get; set; }
        // public DbSet<Monster> Monsters { get; set; }
        // public DbSet<Location> Locations { get; set; }
        // public DbSet<Item> Items { get; set; }
        // public DbSet<Species> Species { get; set; }
        // public DbSet<Element> Elements { get; set; }
        // public DbSet<BattleStats> BattleStats { get; set; }
        // public DbSet<CareStats> CareStats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }
    }
}