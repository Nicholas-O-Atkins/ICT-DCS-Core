namespace WarframeLeftoverAPI.Models
{
    public class Item
    {
        public int Item_Id { get; set; }
        public string Item_Name { get; set; }
        public string Item_Description { get; set;}
        public Item_Type Item_Type { get; set; }
        public ICollection<Tenno_Task_Item> Tenno_Task_Items { get; set; }
        public ICollection<Item_Location> Item_Locations { get; set; }
        public ICollection<Item_Part> Item_Parts { get; set; }
        public ICollection<Item_Material> Item_Materials { get; set; }
    }
}
