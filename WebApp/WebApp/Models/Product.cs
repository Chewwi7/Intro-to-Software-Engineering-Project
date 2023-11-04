using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace WebApp.Models;

public class Product
{
    public string Id { get; set; }
    
    [JsonPropertyName("img")]
    public string Image { get; set; }
    
    public int price { get; set; }
    public string description { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize<Product>(this);
    }
}