namespace WarframeLeftoverAPI.Models
{
    public class Part_Location
    {
        public int Part_Id { get; set; }
        public int Location_Id { get; set; }
        public Part Part { get; set; }
        public Location Location { get; set; }
    }
}
