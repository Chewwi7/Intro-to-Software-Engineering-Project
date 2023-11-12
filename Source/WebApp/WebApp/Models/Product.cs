using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace WebApp.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string name { get; set; }
    [Required]
    public string Image { get; set; }
    [Required]
    public int price { get; set; }
    public string description { get; set; }
    
}