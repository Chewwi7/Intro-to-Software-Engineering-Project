using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WebApp.Models;

namespace WebApp.Data;

public class ApplicationDbContext : IdentityDbContext<Users , IdentityRole<int>, int>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
    {

    }
    
    public DbSet<Users> Users { get; set; }
    public DbSet<Sales> Sales { get; set; }
    public DbSet<Inventory> Inventory { get; set; }
    public DbSet<Checkout>? Checkout { get; set; }
    
}

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseSqlite(@"Data Source=identifier.db");
        
        return new ApplicationDbContext(optionsBuilder.Options);
    }
}

