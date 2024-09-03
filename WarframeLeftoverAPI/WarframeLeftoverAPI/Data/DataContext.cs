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
        public DbSet<TennoTask> Tenno_Tasks { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Material> Materials { get; set; }   
        public DbSet<Location> Locations { get; set; }
        // Offshoots
        public DbSet<TennoRank> TennoRanks { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<PartType> PartTypes { get; set; }
        public DbSet<MaterialType> MaterialTypes { get; set; }
        public DbSet<TennoTaskType> TennoTaskTypes { get; set; }
        // Join Tables
        public DbSet<TennoTaskItem> TennoTaskItems { get; set; }
        public DbSet<TennoTaskPart> TennoTaskParts { get; set; }
        public DbSet<TennoTaskMaterial> TennoTaskMaterials { get; set; }
        public DbSet<ItemPart> ItemParts { get; set; }
        public DbSet<ItemMaterial> ItemMaterials { get; set; }
        public DbSet<ItemLocation> ItemLocations { get; set; }
        public DbSet<PartLocation> PartLocations { get; set; }
        public DbSet<PartMaterial> PartMaterials { get; set; }
        public DbSet<MaterialLocation> MaterialLocations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Tenno_Task_Item override
            modelBuilder.Entity<TennoTaskItem>()
                .HasKey(tti => new { tti.TennoTaskId, tti.ItemId });
            modelBuilder.Entity<TennoTaskItem>()
                .HasOne(t => t.TennoTask)
                .WithMany(tti => tti.TennoTaskItems)
                .HasForeignKey(t => t.TennoTaskId);
            modelBuilder.Entity<TennoTaskItem>()
                .HasOne(i => i.Item)
                .WithMany(tti => tti.TennoTaskItems)
                .HasForeignKey(i => i.ItemId);

            // Tenno_Task_Part Override
            modelBuilder.Entity<TennoTaskPart>()
                .HasKey(ttp => new { ttp.TennoTaskId, ttp.PartId });
            modelBuilder.Entity<TennoTaskPart>()
                .HasOne(t => t.TennoTask)
                .WithMany(ttp => ttp.TennoTaskParts)
                .HasForeignKey(t => t.TennoTaskId);
            modelBuilder.Entity<TennoTaskPart>()
                .HasOne(p => p.Part)
                .WithMany(ttp => ttp.TennoTaskParts)
                .HasForeignKey(p => p.PartId);

            // Tenno_Task_Material Override
            modelBuilder.Entity<TennoTaskMaterial>()
                .HasKey(ttm => new { ttm.TennoTaskId, ttm.MaterialId });
            modelBuilder.Entity<TennoTaskMaterial>()
                .HasOne(t => t.TennoTask)
                .WithMany(ttm => ttm.TennoTaskMaterials)
                .HasForeignKey(t => t.TennoTaskId);
            modelBuilder.Entity<TennoTaskMaterial>()
                .HasOne(m => m.Material)
                .WithMany(ttm => ttm.TennoTaskMaterials)
                .HasForeignKey(m => m.MaterialId);

            // Item_Part Override
            modelBuilder.Entity<ItemPart>()
                .HasKey(ip => new { ip.ItemId, ip.PartId });
            modelBuilder.Entity<ItemPart>()
                .HasOne(i => i.Item)
                .WithMany(ip => ip.ItemParts)
                .HasForeignKey(i => i.ItemId);
            modelBuilder.Entity<ItemPart>()
                .HasOne(p => p.Part)
                .WithMany(ip => ip.ItemParts)
                .HasForeignKey(p => p.PartId);

            // Item_Material Override
            modelBuilder.Entity<ItemMaterial>()
                .HasKey(im => new { im.ItemId, im.MaterialId });
            modelBuilder.Entity<ItemMaterial>()
                .HasOne(i => i.Item)
                .WithMany(im => im.ItemMaterials)
                .HasForeignKey(i => i.ItemId);
            modelBuilder.Entity<ItemMaterial>()
                .HasOne(m => m.Material)
                .WithMany(im => im.ItemMaterials)
                .HasForeignKey(m => m.MaterialId);

            // Item_Location Override
            modelBuilder.Entity<ItemLocation>()
                .HasKey(il => new { il.ItemId, il.LocationId });
            modelBuilder.Entity<ItemLocation>()
                .HasOne(i => i.Item)
                .WithMany(il => il.ItemLocations)
                .HasForeignKey(i => i.ItemId);
            modelBuilder.Entity<ItemLocation>()
                .HasOne(l => l.Location)
                .WithMany(il => il.ItemLocations)
                .HasForeignKey(l => l.LocationId);

            // Part_Location Override
            modelBuilder.Entity<PartLocation>()
                .HasKey(pl => new { pl.PartId, pl.LocationId });
            modelBuilder.Entity<PartLocation>()
                .HasOne(p => p.Part)
                .WithMany(pl => pl.PartLocations)
                .HasForeignKey(p => p.PartId);
            modelBuilder.Entity<PartLocation>()
                .HasOne(l => l.Location)
                .WithMany(il => il.PartLocations)
                .HasForeignKey(l => l.LocationId);

            // Part_Material Override
            modelBuilder.Entity<PartMaterial>()
                .HasKey(pm => new { pm.PartId, pm.MaterialId });
            modelBuilder.Entity<PartMaterial>()
                .HasOne(p => p.Part)
                .WithMany(pm => pm.PartMaterials)
                .HasForeignKey(p => p.PartId);
            modelBuilder.Entity<PartMaterial>()
                .HasOne(m => m.Material)
                .WithMany(pm => pm.PartMaterials)
                .HasForeignKey(m => m.MaterialId);

            // Material_Location Override
            modelBuilder.Entity<MaterialLocation>()
                .HasKey(ml => new { ml.MaterialId, ml.LocationId });
            modelBuilder.Entity<MaterialLocation>()
                .HasOne(m => m.Material)
                .WithMany(ml => ml.MaterialLocations)
                .HasForeignKey(m => m.MaterialId);
            modelBuilder.Entity<MaterialLocation>()
                .HasOne(l => l.Location)
                .WithMany(ml => ml.MaterialLocations)
                .HasForeignKey(l => l.LocationId);
        }
    }
}
