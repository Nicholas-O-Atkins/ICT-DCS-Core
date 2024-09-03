namespace WarframeLeftoverAPI.Models
{
    public class TennoTaskPart
    {
        public int TennoTaskId { get; set; }
        public int PartId { get; set; }
        public int PartQuantity {get; set; }
        public TennoTask TennoTask { get; set; }
        public Part Part { get; set; }
    }
}
