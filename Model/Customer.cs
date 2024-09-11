using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Model
{
    public class Customer
    {
       
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Points { get; set; }

        public Customer( string name, string phone, string email, string address, int points)
        {
            
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            Points = points;
        }

        // Overriding ToString() for better readability
        public override string ToString()
        {
            return $"CustomerId: Name: {Name}, Phone: {Phone}, Email: {Email}, Address: {Address}, Points: {Points}";
        }
    }
}
