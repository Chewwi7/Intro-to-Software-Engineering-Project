using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace WebApp.Models;

public class Users : IdentityUser
{
    [Key]
    public int UserId { get; set; }
    [Required]
    public string username { get; set; }
    [Required]
    public string password { get; set; }
    
    public bool isAdmin { get; set; }
    
}