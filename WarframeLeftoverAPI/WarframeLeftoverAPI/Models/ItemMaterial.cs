namespace WarframeLeftoverAPI.Models
{
    public class ItemMaterial
    {
        public int ItemId { get; set; }
        public int MaterialId { get; set; }
        public int MaterialQuantity {get; set; }
        public Item Item { get; set; }
        public Material Material { get; set; }
    }
}
