namespace WarframeLeftoverAPI.Models
{
    public class Item_Material
    {
        public int Item_Id { get; set; }
        public int Material_Id { get; set; }
        public int Material_Quantity {get; set; }
        public Item Item { get; set; }
        public Material Material { get; set; }
    }
}
