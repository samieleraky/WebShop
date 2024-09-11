using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Model
{
    internal class PaymentMethod
    {
        public string Name { get; set; }

        public PaymentMethod(string name)
        {
            Name = name;
        }
    }
}

