namespace WarframeLeftoverAPI.Models
{
    public class Material
    {
        public int MaterialId { get; set; }
        public string MaterialName { get; set;}
        public MaterialType MaterialType { get; set;}
        public string MaterialDescription { get; set;}
        public ICollection<TennoTaskMaterial> TennoTaskMaterials { get; set;}
        public ICollection<MaterialLocation> MaterialLocations { get; set; }
        public ICollection<PartMaterial> PartMaterials { get; set; }
        public ICollection<ItemMaterial> ItemMaterials { get; set; }
    }
}
