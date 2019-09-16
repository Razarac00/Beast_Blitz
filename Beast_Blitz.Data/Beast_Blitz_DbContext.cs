using Beast_Blitz.Domain.Abstracts;
using Beast_Blitz.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Beast_Blitz.Data
{
    public class Beast_Blitz_DbContext : DbContext
    {
        // ABSTRACTS //
        public DbSet<User> Users { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Accessory> Accessories { get; set; }

        // CONCRETE //
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
            builder.UseSqlServer("server=localhost;initial catalog=Beast_Blitz_Db;user id=sa;password=Password12345");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Monster>().HasOne(m => m.Species);

            builder.Entity<Player>().HasMany(p => p.Pets);
            builder.Entity<Player>().HasMany(p => p.Inventory);

            // builder.Entity<Pet>().HasOne(p => p.Species);
            builder.Entity<Pet>().HasOne(p => p.CareStats);
            builder.Entity<Pet>().HasOne(p => p.BattleStats);

            builder.Entity<Enemy>().HasOne(e => e.BattleStats);

            builder.Entity<Boss>().HasOne(b => b.BattleStats);
            builder.Entity<Boss>().HasOne(b => b.Reward);

            builder.Entity<Shop>().HasMany(s => s.Inventory);

            builder.Entity<Battlefield>().HasMany(b => b.Enemies);
            builder.Entity<Battlefield>().HasOne(b => b.Boss);

            builder.Entity<Species>().HasOne(s => s.BaseStats);
            
        }
    }
}