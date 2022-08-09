namespace WebApplication1.Models
{
    public class Store
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
