namespace WarframeLeftoverAPI.Models
{
    public class Item_Part
    {
        public int Part_Id { get; set; }
        public int Item_Id { get; set; }
        public int Part_Quantity {get; set; }
        public Part Part { get; set; }
        public Item Item { get; set; }
    }
}
