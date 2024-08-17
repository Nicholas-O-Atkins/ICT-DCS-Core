namespace WarframeLeftoverAPI.Models
{
    public class Item_Part
    {
        public int Part_ID { get; set; }
        public int Item_ID { get; set; }
        public Part Part { get; set; }
        public Item Item { get; set; }
    }
}
