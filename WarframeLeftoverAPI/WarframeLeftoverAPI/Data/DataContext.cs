using Microsoft.EntityFrameworkCore;
using WarframeLeftoverAPI.Models;

namespace WarframeLeftoverAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }

        public DbSet<Tenno> Tennos { get; set; }
        public DbSet<Tenno_Task> Tenno_Tasks { get; set; }
        public DbSet<Tenno_Rank> Tenno_Ranks { get; set; }
        public DbSet<Farming_Target> Farming_Targets { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Item_Type> Item_Types { get; set; }
        public DbSet<Item_Material> Item_Materials { get; set; }
        public DbSet<Target_Part> Target_Parts { get; set; }
        public DbSet<Part_Type> Part_Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
