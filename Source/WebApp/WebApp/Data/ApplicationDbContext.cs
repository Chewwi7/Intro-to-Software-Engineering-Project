using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Data;

public class ApplicationDbContext : IdentityDbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(
            "\"C:\\Users\\pnsaj\\Desktop\\Intro-to-Software-Engineering-Project\\Source\\LootX Database\\identifier.db\"");
    }
    
    
    
    
    
}