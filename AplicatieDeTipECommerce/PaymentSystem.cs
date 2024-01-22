using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieDeTipECommerce
{
    internal abstract class PaymentSystem
    {
        internal PaymentSystem(string paymentMethod) 
        {
            PaymentMethod = paymentMethod;
        }
        
        internal string? PaymentMethod {  get; set; }

        internal abstract void PaymentFunctionality(decimal paymentAmount);
    }
}
