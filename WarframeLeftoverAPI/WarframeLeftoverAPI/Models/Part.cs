namespace WarframeLeftoverAPI.Models
{
    public class Part
    {
        public int Part_ID { get; set; }
        public string Part_Name { get; set;}
        public string Part_Description { get; set;}
        public Part_Type Part_Type { get; set;}
        public ICollection<Tenno_Task_Part> Tenno_Task_Parts { get; set;}
        public ICollection<Part_Location> Part_Locations { get; set; }
        public ICollection<Part_Material> Part_Materials { get; set; }
        public ICollection<Item_Part> Item_Parts { get; set; }
    }
}
