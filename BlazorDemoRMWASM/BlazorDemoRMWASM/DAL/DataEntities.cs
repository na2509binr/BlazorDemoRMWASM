using BlazorDemoRMWASM.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemoRMWASM.DAL
{
    public class DataEntities : DbContext
    {
        public DataEntities(DbContextOptions<DataEntities> options) : base(options)
        {
        }

        public DbSet<Menu> Menus { get; set; } = null!;
        public DbSet<ConfigSite> ConfigSites { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().ToTable("Menus");
            modelBuilder.Entity<ConfigSite>().ToTable("ConfigSites");
            base.OnModelCreating(modelBuilder);
        }
    }
}
