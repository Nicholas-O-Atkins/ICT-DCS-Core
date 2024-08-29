namespace WarframeLeftoverAPI.Models
{
    public class Tenno_Task_Part
    {
        public int Tenno_Task_ID { get; set; }
        public int Part_ID { get; set; }
        // public int Quantity {get; set; }
        public Tenno_Task Tenno_Task { get; set; }
        public Part Part { get; set; }
    }
}
