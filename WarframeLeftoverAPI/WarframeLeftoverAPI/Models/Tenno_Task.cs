namespace WarframeLeftoverAPI.Models
{
    public class Tenno_Task
    {
        public int Tenno_Task_ID { get; set; }
        public string Task_name { get; set; }
        public Tenno Tenno { get; set; }
        public Tenno_Task_Item Tenno_Task_Item { get; set; }
        
    }
}
