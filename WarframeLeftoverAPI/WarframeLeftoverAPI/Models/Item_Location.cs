namespace WarframeLeftoverAPI.Models
{
    public class Item_Location
    {
        public int Item_ID { get; set; }
        public int Location_ID { get; set; }
        public Item Item { get; set; }
        public Location Location { get; set; }
    }
}
