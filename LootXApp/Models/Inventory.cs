namespace LootXApp.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public string InventoryName { get; set; }
        public string InventoryDescription { get; set; }
        public string InventoryPic { get; set; }
        public decimal InventoryPrice { get; set; }

        public Inventory()
        {

        }
    }
}
