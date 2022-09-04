using Microsoft.EntityFrameworkCore;
using PreferredElementData.Models;

namespace PreferredElementData
{
    public class PreferredElementDbContext : DbContext
    {
        public DbSet<Brick> Bricks { get; set; }
        public DbSet<BrickColorCode> BrickColorCodes { get; set; }
        public DbSet<ColorCode> ColorCodes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<MasterData> MasterData { get; set; }

        public PreferredElementDbContext(DbContextOptions<PreferredElementDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO: Add index on design id.
            modelBuilder.Entity<Brick>(a => {
                a.Property(b => b.Created).HasDefaultValueSql("getutcdate()");
            });

            modelBuilder.Entity<BrickColorCode>(a => {
                a.Property(b => b.Created).HasDefaultValueSql("getutcdate()");
                a.HasKey(b => new { b.BrickId, b.Order, b.ColorCodeId });
            });

            modelBuilder.Entity<ColorCode>(a => { 
                a.Property(b => b.Created).HasDefaultValueSql("getutcdate()");
                a.Property(b => b.Name).IsRequired();
                a.HasData(  
                    new ColorCode() { Id = 1, Name = "Red" },
                    new ColorCode() { Id = 2, Name = "Green" },
                    new ColorCode() { Id = 3, Name = "Blue" },
                    new ColorCode() { Id = 4, Name = "Yellow" },
                    new ColorCode() { Id = 5, Name = "Orange" },
                    new ColorCode() { Id = 6, Name = "Purple" }
                );
            });

            modelBuilder.Entity<Item>(a => {
                a.Property(b => b.Created).HasDefaultValueSql("getutcdate()");
            });

            modelBuilder.Entity<ItemBrick>(a => {
                a.Property(b => b.Created).HasDefaultValueSql("getutcdate()");
                a.HasKey(b => new { b.ItemId, b.BrickId });
                a.Property(b => b.Amount).IsRequired();
            });

            modelBuilder.Entity<MasterData>(a => {
                a.Property(b => b.Created).HasDefaultValueSql("getutcdate()");
            });
        }
    }
}
