using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Model
{
    public class Payment
    {
       
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public Payment(decimal amount, DateTime paymentDate)
        {
            
            Amount = amount;
            PaymentDate = paymentDate;
        }

        // Overriding ToString() for better readability
        public override string ToString()
        {
            return $"PaymentId: Amount: {Amount:C}, PaymentDate: {PaymentDate}";
        }
    }
}
