using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class Users
{
    [Key]
    public int UserId { get; set; }
    [Required]
    public string username { get; set; }
    [Required]
    public string password { get; set; }
    
    public bool isAdmin { get; set; }
    
}