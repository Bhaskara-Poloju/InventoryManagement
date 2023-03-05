using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class Stock 
    {
        [Key]
        public int Id { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double MinQuantity { get; set; }
        public double Quantity { get; set; }
    }
}
