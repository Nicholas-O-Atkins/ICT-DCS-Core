using Microsoft.EntityFrameworkCore;
using WarframeLeftoverAPI.Models;

namespace WarframeLeftoverAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }

        // Main Tables
        public DbSet<Tenno> Tennos { get; set; }
        public DbSet<Tenno_Task> Tenno_Tasks { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Material> Materials { get; set; }   
        public DbSet<Location> Locations { get; set; }
        // Offshoots
        public DbSet<Tenno_Rank> Tenno_Ranks { get; set; }
        public DbSet<Item_Type> Item_Types { get; set; }
        // Join Tables
        public DbSet<Tenno_Task_Item> Tenno_Task_Items { get; set; }
        public DbSet<Item_Part> Item_Parts { get; set; }
        public DbSet<Item_Material> Item_Materials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
