using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        [Required]
        public int QuantityAvailable { get; set; }
        
        public System.DateTime DateAdded { get; set; }
    }
}
