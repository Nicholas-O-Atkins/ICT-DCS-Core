namespace WarframeLeftoverAPI.Models
{
    public class Location
    {
        public int Location_Id { get; set; }
        public string Location_Name { get; set;}
        public ICollection<Item_Location> Item_Locations { get; set; }
        public ICollection<Part_Location> Part_Locations { get; set; }
        public ICollection<Material_Location> Material_Locations { get; set; }        
    }
}
