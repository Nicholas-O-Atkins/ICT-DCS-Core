namespace WarframeLeftoverAPI.Models
{
    public class Farming_Target
    {
        public int Farming_Target_ID { get; set; }
        public String Farming_Target_Name { get; set; }
        public Item_Type Farming_Target_Type { get; set; }
        public ICollection<Target_Part> Parts { get; set; }
        public DateTime Creation_Date { get; set; }
        public DateTime Update_Date { get; set; }
    }
}
