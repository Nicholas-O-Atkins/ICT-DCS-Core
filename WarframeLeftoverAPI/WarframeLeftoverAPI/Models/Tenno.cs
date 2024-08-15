namespace WarframeLeftoverAPI.Models
{
    public class Tenno
    {
        public int Tenno_ID { get; set; }
        public string Name { get; set; }
        public string UserEmail { get; set; }
        public Tenno_Rank Tenno_Rank { get; set; }
        public ICollection<Tenno_Task> Tasks { get; set; }
        public DateTime Creation_Date { get; set; }
        public DateTime Update_Date { get; set; }
    }
}
