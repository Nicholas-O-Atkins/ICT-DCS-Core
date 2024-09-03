namespace WarframeLeftoverAPI.Models
{
    public class TennoTask
    {
        public int TennoTaskId { get; set; }
        public string Taskname { get; set; }
        public string TaskDescription { get; set; }
        public Tenno Tenno { get; set; }
        public TennoTaskType TennoTaskType { get; set; }
        public ICollection<TennoTaskItem> TennoTaskItems { get; set; }
        public ICollection<TennoTaskPart> TennoTaskParts { get; set; }
        public ICollection<TennoTaskMaterial> TennoTaskMaterials { get; set; }
    }
}
