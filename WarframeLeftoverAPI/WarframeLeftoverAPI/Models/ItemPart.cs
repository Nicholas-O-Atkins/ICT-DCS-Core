namespace WarframeLeftoverAPI.Models
{
    public class ItemPart
    {
        public int PartId { get; set; }
        public int ItemId { get; set; }
        public int PartQuantity {get; set; }
        public Part Part { get; set; }
        public Item Item { get; set; }
    }
}
