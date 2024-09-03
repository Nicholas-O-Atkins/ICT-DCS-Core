namespace WarframeLeftoverAPI.Models
{
    public class ItemLocation
    {
        public int ItemId { get; set; }
        public int LocationId { get; set; }
        public Item Item { get; set; }
        public Location Location { get; set; }
    }
}
