namespace WarframeLeftoverAPI.Models
{
    public class Tenno_Task_Material
    {
        public int Tenno_Task_Id { get; set; }
        public int Material_Id { get; set; }
        public int Material_Quantity {get; set; }
        public Tenno_Task Tenno_Task { get; set; }
        public Material Material { get; set; }
    }
}
