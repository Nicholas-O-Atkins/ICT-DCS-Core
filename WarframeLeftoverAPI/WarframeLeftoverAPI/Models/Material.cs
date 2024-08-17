namespace WarframeLeftoverAPI.Models
{
    public class Material
    {
        public int Material_ID { get; set; }
        public string Material_Name { get; set;}
        public Material_Type Material_Type { get; set;}
        public string Material_Description { get; set;}
        public ICollection<Tenno_Task_Material> Tenno_Task_Materials { get; set;}
        public ICollection<Material_Location> Material_Locations { get; set; }
        public ICollection<Part_Material> Part_Materials { get; set; }
        public ICollection<Item_Material> Item_Materials { get; set; }
    }
}
