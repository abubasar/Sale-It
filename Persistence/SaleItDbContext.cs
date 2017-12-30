using Microsoft.EntityFrameworkCore;
using SaleIt.Models;

namespace SaleIt.Persistence
{
    public class SaleItDbContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        public SaleItDbContext(DbContextOptions<SaleItDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeature>()
                .HasKey(e => new
                {
                    e.FeatureId, e.VehicleId
                });

        }
    }
}