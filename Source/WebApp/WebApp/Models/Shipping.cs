using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class Shipping
{
    [Key]
    public int ShippingTypeId { get; set; }
    
    public string ShippingTypeName { get; set; }
    public float ShippingTypePrice { get; set; }
}