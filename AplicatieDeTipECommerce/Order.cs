using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieDeTipECommerce
{
    internal class Order
    {
        internal Order(string customer, DateTime date, decimal total) 
        {
            Customer = customer;
            Date = date;
            Total = total;
        }

        internal string Customer {  get; set; }

        internal DateTime Date { get; set; }

        internal decimal Total { get; set; }


    }
}
