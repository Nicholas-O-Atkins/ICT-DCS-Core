namespace WarframeLeftoverAPI.Models
{
    public class Material_Type
    {
        public int Material_Type_ID { get; set; }
        public string Material_Type_Name { get; set; }
        public string Material_Type_Description { get; set; }
        public ICollection<Material> materials { get; set; }
    }
}
