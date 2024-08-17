namespace WarframeLeftoverAPI.Models
{
    public class Part_Location
    {
        public int Part_ID { get; set; }
        public int Location_ID { get; set; }
        public Part Part { get; set; }
        public Location Location { get; set; }
    }
}
