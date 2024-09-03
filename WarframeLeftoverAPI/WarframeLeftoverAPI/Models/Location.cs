namespace WarframeLeftoverAPI.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set;}
        public ICollection<ItemLocation> ItemLocations { get; set; }
        public ICollection<PartLocation> PartLocations { get; set; }
        public ICollection<MaterialLocation> MaterialLocations { get; set; }        
    }
}
