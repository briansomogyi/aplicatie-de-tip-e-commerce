using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieDeTipECommerce
{
    internal class OrderProcessor
    {
        internal static void FulfillOrder(Order order, PaymentSystem paymentSystem)
        {
            if (order == null) 
            {
                throw new ArgumentNullException($"{nameof(order)}","Cannot insert a null order.");
            }

            Console.WriteLine($"Customer {order.Customer} is paying ${order.Total} by {paymentSystem.PaymentMethod} now at {order.Date}");
        }
    }
}
