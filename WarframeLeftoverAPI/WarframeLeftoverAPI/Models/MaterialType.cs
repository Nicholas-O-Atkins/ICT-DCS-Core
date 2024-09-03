namespace WarframeLeftoverAPI.Models
{
    public class MaterialType
    {
        public int MaterialTypeId { get; set; }
        public string MaterialTypeName { get; set; }
        public string MaterialTypeDescription { get; set; }
        public ICollection<Material> Materials { get; set; }
    }
}
