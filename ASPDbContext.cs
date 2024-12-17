using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Text.Json;

namespace ASPNET
{
    public class ASPDbContext : DbContext
    {
        public DbSet<Rules> Rules { get; set; }
        public DbSet<Shops> Shops { get; set; }
        public DbSet<Treasure> Treasures { get; set; }
        public DbSet<About> About { get; set; }
        public ASPDbContext(DbContextOptions<ASPDbContext> options)
        : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            int currRuleId = 0;
            List<Rules> rules = JsonSerializer.Deserialize<List<Rules>>(File.ReadAllText("Resources/Rules.json"));
            foreach (Rules rule in rules) rule.Id = ++currRuleId;

            int currShopId = 0;
            List<Shops> shops = JsonSerializer.Deserialize<List<Shops>>(File.ReadAllText("Resources/Shops.json"));
            foreach (Shops shop in shops) shop.Id = ++currShopId;

            int currTreasureId = 0;
            List<Treasure> treasures = JsonSerializer.Deserialize<List<Treasure>>(File.ReadAllText("Resources/Treasures.json"));
            foreach (Treasure treasure in treasures) treasure.Id = ++currTreasureId;

            About about = JsonSerializer.Deserialize<About>(File.ReadAllText("Resources/About.json"));

            modelBuilder.Entity<Rules>().HasData(rules);
            modelBuilder.Entity<Rules>().HasKey(r => r.Id);

            modelBuilder.Entity<Shops>().HasData(shops);
            modelBuilder.Entity<Shops>().HasKey(s => s.Id);

            modelBuilder.Entity<Treasure>().HasData(treasures);
            modelBuilder.Entity<Treasure>().HasKey(t => t.Id);

            modelBuilder.Entity<About>().HasData(about);
            modelBuilder.Entity<About>().HasKey(a => a.Name);
        }
    }
}
