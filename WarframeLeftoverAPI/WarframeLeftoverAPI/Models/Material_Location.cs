namespace WarframeLeftoverAPI.Models
{
    public class Material_Location
    {
        public int Material_Id { get; set; }
        public int Location_Id { get; set; }
        public Material Material { get; set; }
        public Location Location { get; set; }
    }
}
