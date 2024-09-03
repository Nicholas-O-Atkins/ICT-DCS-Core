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
        public DbSet<Part_Type> Part_Types { get; set; }
        public DbSet<Material_Type> Material_Types { get; set; }
        public DbSet<Tenno_Task_Type> Tenno_Task_Types { get; set; }
        // Join Tables
        public DbSet<Tenno_Task_Item> Tenno_Task_Items { get; set; }
        public DbSet<Tenno_Task_Part> Tenno_Task_Parts { get; set; }
        public DbSet<Tenno_Task_Material> Tenno_Task_Materials { get; set; }
        public DbSet<Item_Part> Item_Parts { get; set; }
        public DbSet<Item_Material> Item_Materials { get; set; }
        public DbSet<Item_Location> Item_Locations { get; set; }
        public DbSet<Part_Location> Part_Locations { get; set; }
        public DbSet<Part_Material> Part_Materials { get; set; }
        public DbSet<Material_Location> Material_Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Tenno_Task_Item override
            modelBuilder.Entity<Tenno_Task_Item>()
                .HasKey(tti => new { tti.Tenno_Task_Id, tti.Item_Id });
            modelBuilder.Entity<Tenno_Task_Item>()
                .HasOne(t => t.Tenno_Task)
                .WithMany(tti => tti.Tenno_Task_Items)
                .HasForeignKey(t => t.Tenno_Task_Id);
            modelBuilder.Entity<Tenno_Task_Item>()
                .HasOne(i => i.Item)
                .WithMany(tti => tti.Tenno_Task_Items)
                .HasForeignKey(i => i.Item_Id);

            // Tenno_Task_Part Override
            modelBuilder.Entity<Tenno_Task_Part>()
                .HasKey(ttp => new { ttp.Tenno_Task_Id, ttp.Part_Id });
            modelBuilder.Entity<Tenno_Task_Part>()
                .HasOne(t => t.Tenno_Task)
                .WithMany(ttp => ttp.Tenno_Task_Parts)
                .HasForeignKey(t => t.Tenno_Task_Id);
            modelBuilder.Entity<Tenno_Task_Part>()
                .HasOne(p => p.Part)
                .WithMany(ttp => ttp.Tenno_Task_Parts)
                .HasForeignKey(p => p.Part_Id);

            // Tenno_Task_Material Override
            modelBuilder.Entity<Tenno_Task_Material>()
                .HasKey(ttm => new { ttm.Tenno_Task_Id, ttm.Material_Id });
            modelBuilder.Entity<Tenno_Task_Material>()
                .HasOne(t => t.Tenno_Task)
                .WithMany(ttm => ttm.Tenno_Task_Materials)
                .HasForeignKey(t => t.Tenno_Task_Id);
            modelBuilder.Entity<Tenno_Task_Material>()
                .HasOne(m => m.Material)
                .WithMany(ttm => ttm.Tenno_Task_Materials)
                .HasForeignKey(m => m.Material_Id);

            // Item_Part Override
            modelBuilder.Entity<Item_Part>()
                .HasKey(ip => new { ip.Item_Id, ip.Part_Id });
            modelBuilder.Entity<Item_Part>()
                .HasOne(i => i.Item)
                .WithMany(ip => ip.Item_Parts)
                .HasForeignKey(i => i.Item_Id);
            modelBuilder.Entity<Item_Part>()
                .HasOne(p => p.Part)
                .WithMany(ip => ip.Item_Parts)
                .HasForeignKey(p => p.Part_Id);

            // Item_Material Override
            modelBuilder.Entity<Item_Material>()
                .HasKey(im => new { im.Item_Id, im.Material_Id });
            modelBuilder.Entity<Item_Material>()
                .HasOne(i => i.Item)
                .WithMany(im => im.Item_Materials)
                .HasForeignKey(i => i.Item_Id);
            modelBuilder.Entity<Item_Material>()
                .HasOne(m => m.Material)
                .WithMany(im => im.Item_Materials)
                .HasForeignKey(m => m.Material_Id);

            // Item_Location Override
            modelBuilder.Entity<Item_Location>()
                .HasKey(il => new { il.Item_Id, il.Location_Id });
            modelBuilder.Entity<Item_Location>()
                .HasOne(i => i.Item)
                .WithMany(il => il.Item_Locations)
                .HasForeignKey(i => i.Item_Id);
            modelBuilder.Entity<Item_Location>()
                .HasOne(l => l.Location)
                .WithMany(il => il.Item_Locations)
                .HasForeignKey(l => l.Location_Id);

            // Part_Location Override
            modelBuilder.Entity<Part_Location>()
                .HasKey(pl => new { pl.Part_Id, pl.Location_Id });
            modelBuilder.Entity<Part_Location>()
                .HasOne(p => p.Part)
                .WithMany(pl => pl.Part_Locations)
                .HasForeignKey(p => p.Part_Id);
            modelBuilder.Entity<Part_Location>()
                .HasOne(l => l.Location)
                .WithMany(il => il.Part_Locations)
                .HasForeignKey(l => l.Location_Id);

            // Part_Material Override
            modelBuilder.Entity<Part_Material>()
                .HasKey(pm => new { pm.Part_Id, pm.Material_Id });
            modelBuilder.Entity<Part_Material>()
                .HasOne(p => p.Part)
                .WithMany(pm => pm.Part_Materials)
                .HasForeignKey(p => p.Part_Id);
            modelBuilder.Entity<Part_Material>()
                .HasOne(m => m.Material)
                .WithMany(pm => pm.Part_Materials)
                .HasForeignKey(m => m.Material_Id);

            // Material_Location Override
            modelBuilder.Entity<Material_Location>()
                .HasKey(ml => new { ml.Material_Id, ml.Location_Id });
            modelBuilder.Entity<Material_Location>()
                .HasOne(m => m.Material)
                .WithMany(ml => ml.Material_Locations)
                .HasForeignKey(m => m.Material_Id);
            modelBuilder.Entity<Material_Location>()
                .HasOne(l => l.Location)
                .WithMany(ml => ml.Material_Locations)
                .HasForeignKey(l => l.Location_Id);
        }
    }
}
