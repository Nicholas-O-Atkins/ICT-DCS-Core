namespace WarframeLeftoverAPI.Models
{
    public class Part
    {
        public int PartId { get; set; }
        public string PartName { get; set;}
        public string PartDescription { get; set;}
        public PartType PartType { get; set;}
        public ICollection<TennoTaskPart> TennoTaskParts { get; set;}
        public ICollection<PartLocation> PartLocations { get; set; }
        public ICollection<PartMaterial> PartMaterials { get; set; }
        public ICollection<ItemPart> ItemParts { get; set; }
    }
}
