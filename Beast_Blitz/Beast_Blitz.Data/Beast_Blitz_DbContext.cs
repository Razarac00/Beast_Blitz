using Beast_Blitz.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Beast_Blitz.Data
{
    public class Beast_Blitz_DbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet<Boss> Bosses { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Battlefield> Battlefields { get; set; }
        public DbSet<Treat> Treats { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Potion> Potions { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<Hat> Hats { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Element> Elements { get; set; }
        public DbSet<BattleStats> BattleStats { get; set; }
        public DbSet<CareStats> CareStats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Player>().HasMany(p => p.Pets);
            builder.Entity<Player>().HasMany(p => p.Inventory);

            builder.Entity<Pet>().HasOne(p => p.CareStats);
            builder.Entity<Pet>().HasOne(p => p.BattleStats);

            builder.Entity<Enemy>().HasOne(e => e.BattleStats);

            builder.Entity<Boss>().HasOne(b => b.BattleStats);
            builder.Entity<Boss>().HasOne(b => b.Reward);
        }
    }
}