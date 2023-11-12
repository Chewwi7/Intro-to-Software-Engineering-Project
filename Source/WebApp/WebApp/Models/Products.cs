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
    public string name { get; set; }
    [Required]
    public string Image { get; set; }
    [Required]
    public int price { get; set; }
    [Required]
    public string description { get; set; }
    
}