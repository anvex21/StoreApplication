using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApplication.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
