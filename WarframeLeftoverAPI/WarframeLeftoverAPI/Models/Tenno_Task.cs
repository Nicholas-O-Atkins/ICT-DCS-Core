namespace WarframeLeftoverAPI.Models
{
    public class Tenno_Task
    {
        public int Tenno_Task_ID { get; set; }
        public string Task_name { get; set; }
        public Tenno Tenno { get; set; }
        public Tenno_Task_Type Tenno_Task_Type { get; set; }
        public ICollection<Tenno_Task_Item> Tenno_Task_Items { get; set; }
        public ICollection<Tenno_Task_Part> Tenno_Task_Parts { get; set; }
        public ICollection<Tenno_Task_Material> Tenno_Task_Materials { get; set; }
    }
}
