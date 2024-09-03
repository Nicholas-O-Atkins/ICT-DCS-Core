namespace WarframeLeftoverAPI.Models
{
    public class Item
    {
        public int ItemId  { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set;}
        public ItemType ItemType { get; set; }
        public ICollection<TennoTaskItem> TennoTaskItems { get; set; }
        public ICollection<ItemLocation> ItemLocations { get; set; }
        public ICollection<ItemPart> ItemParts { get; set; }
        public ICollection<ItemMaterial> ItemMaterials { get; set; }
    }
}
