namespace WarframeLeftoverAPI.Models
{
    public class TennoRank
    {
        public int TennoRankId { get; set; }
        public string TennoRankName { get; set; }
        public ICollection<Tenno> Tennos { get; set; }
    }
}
