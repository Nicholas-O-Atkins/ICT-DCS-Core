namespace WarframeLeftoverAPI.Models
{
    public class Part_Type
    {
        public int Part_Type_Id { get; set; }
        public string Part_Type_Name { get; set; }
        public ICollection<Part> Parts { get; set; }
    }
}
