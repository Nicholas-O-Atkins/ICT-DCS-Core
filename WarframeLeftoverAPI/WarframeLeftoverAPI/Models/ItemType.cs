namespace WarframeLeftoverAPI.Models
{
    public class ItemType
    {
        public int ItemTypeId { get; set; }
        public string ItemTypeName { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
