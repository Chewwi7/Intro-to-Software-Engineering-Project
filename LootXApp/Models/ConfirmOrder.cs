namespace LootXApp.Models;

public class ConfirmOrder
{
    public int CheckoutId { get; set; }
    public string InventoryName { get; set; }
    public string InventoryPic { get; set; }
    public decimal InventoryPrice { get; set; }

    public ConfirmOrder()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}