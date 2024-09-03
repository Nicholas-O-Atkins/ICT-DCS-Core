namespace WarframeLeftoverAPI.Models
{
    public class PartType
    {
        public int PartTypeId { get; set; }
        public string PartTypeName { get; set; }
        public ICollection<Part> Parts { get; set; }
    }
}
