using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace WebApp.Models;

public class Product
{
    
    public int Id { get; set; }
    public string name { get; set; }
    public string Image { get; set; }
    public int price { get; set; }
    public string description { get; set; }
    
}