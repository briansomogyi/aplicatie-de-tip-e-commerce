using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieDeTipECommerce
{
    internal class CreditCard:PaymentSystem
    {
        internal CreditCard(string paymentMethod) : base(paymentMethod) { }

        internal override void PaymentFunctionality(decimal paymentAmount)
        {
            Console.WriteLine($"Paying ${paymentAmount} by credit card.");
        }
    }
}
