namespace WarframeLeftoverAPI.Models
{
    public class PartLocation
    {
        public int PartId { get; set; }
        public int LocationId { get; set; }
        public Part Part { get; set; }
        public Location Location { get; set; }
    }
}
