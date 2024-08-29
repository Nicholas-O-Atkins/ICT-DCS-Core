namespace WarframeLeftoverAPI.Models
{
    public class Tenno_Task_Material
    {
        public int Tenno_Task_ID { get; set; }
        public int Material_ID { get; set; }
        // public int Quantity {get; set; }
        public Tenno_Task Tenno_Task { get; set; }
        public Material Material { get; set; }
    }
}
