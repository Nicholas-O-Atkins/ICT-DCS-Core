namespace WarframeLeftoverAPI.Models
{
    public class Part_Material
    {
        public int Material_Id { get; set; }
        public int Part_Id { get; set; }
        public int Material_Quantity {get; set; }
        public Material Material { get; set; }
        public Part Part { get; set; }
    }
}
