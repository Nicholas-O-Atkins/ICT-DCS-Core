namespace WarframeLeftoverAPI.Models
{
    public class Tenno_Task
    {
        public int Tenno_Task_ID { get; set; }
        public int Tenno_ID { get; set; }
        public int Farming_Target_ID { get; set; }
        public Tenno Tenno { get; set; }
        public Farming_Target Farming_Target { get; set; }
        public string Task_name { get; set; }
        public DateTime Creation_Date { get; set; }
        public DateTime Update_Date { get; set; }
    }
}
