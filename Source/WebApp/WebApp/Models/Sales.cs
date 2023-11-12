using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;

public class Sales
{
    [Key]
    public int saleId { get; set; }
    //Foreign Keys
    [Display(Name = "User")]
    public virtual int UserId { get; set; }
    
    [ForeignKey("UserId")]
    public virtual Users Users { get; set; }
    
    [Display(Name = "Product")]
    public virtual int ProductId { get; set; }
    
    [ForeignKey("ProductId")]
    public virtual Products Products { get; set; }
    
    public DateTime soldDate { get; set; }
    
    //Payment and Contact Info
    public String address { get; set; }
    public String phoneNumber { get; set; }
    public String creditCardNumber { get; set; }
    public String expirationDate { get; set; }
    public String CVV { get; set; }
    
    
    

    public int shippingTypeId { get; set; }
    public float tax { get; set; }
    public float subtotal { get; set; }
    public float total { get; set; }
    
}