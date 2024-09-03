namespace WarframeLeftoverAPI.Models
{
    public class TennoTaskItem
    {
        public int TennoTaskId { get; set; }
        public int ItemId { get; set; }
        public int ItemQuantity {get; set; }
        public TennoTask TennoTask { get; set; }
        public Item Item { get; set; }

    }
}
