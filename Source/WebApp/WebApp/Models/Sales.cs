using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;

public class Sales
{
    [Key]
    public int SaleId { get; set; }
    
    //Foreign Key For UserId
    [Display(Name = "User")]
    public virtual int UserId { get; set; }
    [ForeignKey("UserId")]
    public virtual Users Users { get; set; }
    
    //Foreign Key for InventoryId
    [Display(Name = "Inventory")]
    public virtual int InventoryId { get; set; }
    [ForeignKey("InventoryId")]
    public virtual Inventory Inventorys { get; set; }
    
    
    
    //To get and set the date the product was sold
    public DateTime SoldDate { get; set; }
    
    //Payment and Contact Info
    
    public string StreetName { get; set; }
    public string CityName { get; set; }
    public string StateName { get; set; }
    public string ZipCode { get; set; }
    public string PhoneNumber { get; set; }
    public string CreditCardNumber { get; set; }
    public string ExpirationDate { get; set; }
    public string CVV { get; set; }



    [Display(Name = "ShippingTypeId")]
    public virtual int ShippingTypeId { get; set; }
    [ForeignKey("ShippingTypeId")]
    public virtual Shipping Shipping { get; set; }
    
    
    public decimal tax { get; set; }
    public decimal subtotal { get; set; }
    public decimal total { get; set; }
    
}