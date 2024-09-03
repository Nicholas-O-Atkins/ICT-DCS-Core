namespace WarframeLeftoverAPI.Models
{
    public class Tenno_Task_Part
    {
        public int Tenno_Task_Id { get; set; }
        public int Part_Id { get; set; }
        public int Part_Quantity {get; set; }
        public Tenno_Task Tenno_Task { get; set; }
        public Part Part { get; set; }
    }
}
