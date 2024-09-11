using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Model
{
    public class Order
    {
        
        public DateTime OrderDate { get; set; }
        public string DeliveryStatus { get; set; }
        public decimal TotalAmount { get; set; }

        public Order( DateTime orderDate, string deliveryStatus, decimal totalAmount)
        {
            
            OrderDate = orderDate;
            DeliveryStatus = deliveryStatus;
            TotalAmount = totalAmount;
        }

        // Overriding ToString() for better readability
        public override string ToString()
        {
            return $"OrderId: OrderDate: {OrderDate}, DeliveryStatus: {DeliveryStatus}, TotalAmount: {TotalAmount:C}";
        }
    }
}
