namespace WebApp.Models;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Checkout
{
    public int CheckoutId { get; set; }
    public string InventoryName { get; set; }
    public string InventoryPic { get; set; }
    public decimal InventoryPrice { get; set; }

    public Checkout()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}