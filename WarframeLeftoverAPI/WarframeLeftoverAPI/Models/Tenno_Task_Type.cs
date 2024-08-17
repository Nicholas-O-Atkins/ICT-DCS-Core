namespace WarframeLeftoverAPI.Models
{
    public class Tenno_Task_Type
    {
        public int Tenno_Task_Type_ID { get; set; }
        public int Tenno_Task_Type_Name { get; set; }
        public int Tenno_Task_Type_Desciption { get; set; }
        public ICollection<Tenno_Task> Tenno_Task { get; set; }
    }
}
