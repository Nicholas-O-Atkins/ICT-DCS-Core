namespace WarframeLeftoverAPI.Models
{
    public class Tenno
    {
        public int TennoId { get; set; }
        public string Name { get; set; }
        public TennoRank TennoRank { get; set; }
        public ICollection<TennoTask> TennoTasks { get; set; }
    }
}
