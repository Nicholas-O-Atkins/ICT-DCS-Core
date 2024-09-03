namespace WarframeLeftoverAPI.Models
{
    public class TennoTaskMaterial
    {
        public int TennoTaskId { get; set; }
        public int MaterialId { get; set; }
        public int MaterialQuantity {get; set; }
        public TennoTask TennoTask { get; set; }
        public Material Material { get; set; }
    }
}
