namespace WarframeLeftoverAPI.Models
{
    public class Warframes
    {
        public int Warframe_ID { get; set; }
        public string Warframe_Name { get; set; }
        public bool Checked { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
