namespace WarframeLeftoverAPI.Models
{
    public class Item_Location
    {
        public int Item_Id { get; set; }
        public int Location_Id { get; set; }
        public Item Item { get; set; }
        public Location Location { get; set; }
    }
}
