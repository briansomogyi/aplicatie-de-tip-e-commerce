using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieDeTipECommerce
{
    public class Order
    {
        public Order(string customer, DateTime date, decimal total) 
        {
            Customer = customer;
            Date = date;
            Total = total;
        }

        public string Customer {  get; set; }

        public DateTime Date { get; set; }

        public decimal Total { get; set; }


    }
}
