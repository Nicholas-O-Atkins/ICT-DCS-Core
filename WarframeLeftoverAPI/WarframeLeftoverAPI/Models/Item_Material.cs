namespace WarframeLeftoverAPI.Models
{
    public class Item_Material
    {
        public int Material_ID { get; set; }
        public int Target_Part_ID { get; set; }
        public Material Material { get; set; }
        public Target_Part Target_Part { get; set; }
        public int Quantity { get; set; }
        public DateTime Creation_Date { get; set; }
        public DateTime Update_Date { get; set; }
    }
}
