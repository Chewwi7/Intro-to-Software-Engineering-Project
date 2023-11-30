using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace WebApp.Models;

public class Products
{
    [Key]
    public int ProductId { get; set; }
    [Required]
    public string ProductName { get; set; }
    [Required]
    public string ProductImage { get; set; }
    [Required]
    public float ProductPrice { get; set; }
    [Required]
    public string ProductDescription { get; set; }
    
}