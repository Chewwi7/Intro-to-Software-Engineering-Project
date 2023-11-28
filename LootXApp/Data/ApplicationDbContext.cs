using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LootXApp.Models;

namespace LootXApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LootXApp.Models.Inventory>? Inventory { get; set; }
        public DbSet<Checkout>? Checkout { get; set; }
    }
}