namespace WarframeLeftoverAPI.Models
{
    public class TennoTaskType
    {
        public int TennoTaskTypeId { get; set; }
        public int TennoTaskTypeName { get; set; }
        public int TennoTaskTypeDesciption { get; set; }
        public ICollection<TennoTask> TennoTask { get; set; }
    }
}
