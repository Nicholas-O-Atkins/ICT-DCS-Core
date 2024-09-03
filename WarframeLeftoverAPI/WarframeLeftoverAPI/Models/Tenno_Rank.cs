namespace WarframeLeftoverAPI.Models
{
    public class Tenno_Rank
    {
        public int Tenno_Rank_Id { get; set; }
        public string Tenno_Rank_Name { get; set; }
        public ICollection<Tenno> Tennos { get; set; }
    }
}
