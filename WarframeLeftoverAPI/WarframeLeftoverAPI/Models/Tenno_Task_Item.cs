namespace WarframeLeftoverAPI.Models
{
    public class Tenno_Task_Item
    {
        public int Tenno_Task_Id { get; set; }
        public int Item_Id { get; set; }
        public int Item_Quantity {get; set; }
        public Tenno_Task Tenno_Task { get; set; }
        public Item Item { get; set; }

    }
}
