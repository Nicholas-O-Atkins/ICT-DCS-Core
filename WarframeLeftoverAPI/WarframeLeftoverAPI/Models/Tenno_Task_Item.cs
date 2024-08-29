namespace WarframeLeftoverAPI.Models
{
    public class Tenno_Task_Item
    {
        public int Tenno_Task_ID { get; set; }
        public int Item_ID { get; set; }
        /public int Item_Quantity {get; set; }
        public Tenno_Task Tenno_Task { get; set; }
        public Item Item { get; set; }

    }
}
