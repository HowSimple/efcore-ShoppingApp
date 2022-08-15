using System.ComponentModel.DataAnnotations;

namespace StoreApp.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        [Required]
        public string Category { get; set; }
        public int QuantityAvailable { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
