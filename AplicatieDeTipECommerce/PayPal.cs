using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieDeTipECommerce
{
    internal class PayPal:PaymentSystem
    {
        internal PayPal(string paymentMethod) : base(paymentMethod) { }

        internal override void PaymentFunctionality(decimal paymentAmount)
        {
            Console.WriteLine($"Paying ${paymentAmount} by {nameof(PayPal)}.");
        }
    }
}
