using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
