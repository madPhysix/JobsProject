using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace JobsProject
{
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product()
        {
            
        }
    }

    
}
