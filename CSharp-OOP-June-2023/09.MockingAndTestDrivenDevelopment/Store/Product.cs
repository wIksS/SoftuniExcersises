using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Product
    {
        public Product(int id, string name, string manufacturer, string description, decimal price)
        {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
            Description = description;
            Price = price;
        }

        public Product()
        {

        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
