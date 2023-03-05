using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class SalesOrder
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string MyProperty { get; set; }
    }
}
