namespace WarframeLeftoverAPI.Models
{
    public class Item_Type
    {
        public int Item_Type_Id { get; set; }
        public string Item_Type_Name { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
