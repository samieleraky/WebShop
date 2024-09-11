using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Model
{
    internal class Product
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int StockStatus { get; set; }

        public Product(string name, string description, double price, int stockStatus)
        {
            Name = name;
            Description = description;
            Price = price;
            StockStatus = stockStatus;
        }
    }
}
