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
    
    //Foreign Key for ProductId
    [Display(Name = "Product")]
    public virtual int ProductId { get; set; }
    [ForeignKey("ProductId")]
    public virtual Products Products { get; set; }
    
    //To get and set the date the product was sold
    public DateTime SoldDate { get; set; }
    
    //Payment and Contact Info
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string CreditCardNumber { get; set; }
    public string ExpirationDate { get; set; }
    public string CVV { get; set; }



    [Display(Name = "ShippingTypeId")]
    public virtual int ShippingTypeId { get; set; }
    [ForeignKey("ShippingTypeId")]
    public virtual Shipping Shipping { get; set; }
    
    
    public float tax { get; set; }
    public float subtotal { get; set; }
    public float total { get; set; }
    
}