using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Model
{

    internal class ShoppingCart

    {

        public string Product { get; set; }

        public double Price { get; set; }

        public int Amount { get; set; }

        public ShoppingCart(string product, double price, int amount)

        {

            Product = product;

            Price = price;

            Amount = amount;

        }

    }

}



