using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }
        
        [Required]
        public string InventoryName { get; set; }
        
        [Required]
        public string InventoryDescription { get; set; }
        
        [Required]
        public string InventoryPic { get; set; }
        
        [Required]
        public decimal InventoryPrice { get; set; }
        
    }
}
