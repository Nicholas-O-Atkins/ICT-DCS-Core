namespace WarframeLeftoverAPI.Models
{
    public class Material_Location
    {
        public int Material_ID { get; set; }
        public int Location_ID { get; set; }
        public Material Material { get; set; }
        public Location Location { get; set; }
    }
}
