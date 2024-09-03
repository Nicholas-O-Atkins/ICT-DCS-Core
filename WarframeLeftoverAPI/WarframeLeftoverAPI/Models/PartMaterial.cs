namespace WarframeLeftoverAPI.Models
{
    public class PartMaterial
    {
        public int MaterialId { get; set; }
        public int PartId { get; set; }
        public int MaterialQuantity {get; set; }
        public Material Material { get; set; }
        public Part Part { get; set; }
    }
}
