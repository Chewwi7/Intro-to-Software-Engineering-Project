namespace LootXApp.Models
{
    //This is the template used to generate the Inventory table and its components
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
