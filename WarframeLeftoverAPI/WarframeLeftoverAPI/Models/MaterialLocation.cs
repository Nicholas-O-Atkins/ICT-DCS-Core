namespace WarframeLeftoverAPI.Models
{
    public class MaterialLocation
    {
        public int MaterialId { get; set; }
        public int LocationId { get; set; }
        public Material Material { get; set; }
        public Location Location { get; set; }
    }
}
