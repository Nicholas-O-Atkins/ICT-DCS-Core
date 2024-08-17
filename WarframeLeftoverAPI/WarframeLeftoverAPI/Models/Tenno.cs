namespace WarframeLeftoverAPI.Models
{
    public class Tenno
    {
        public int Tenno_ID { get; set; }
        public string Name { get; set; }
        public Tenno_Rank Tenno_Rank { get; set; }
        public ICollection<Tenno_Task> Tenno_Tasks { get; set; }
    }
}
