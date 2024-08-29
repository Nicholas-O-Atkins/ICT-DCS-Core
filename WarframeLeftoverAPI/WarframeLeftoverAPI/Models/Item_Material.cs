namespace WarframeLeftoverAPI.Models
{
    public class Item_Material
    {
        public int Item_ID { get; set; }
        public int Material_ID { get; set; }
        public int Material_Quantity {get; set; }
        public Item Item { get; set; }
        public Material Material { get; set; }
    }
}
