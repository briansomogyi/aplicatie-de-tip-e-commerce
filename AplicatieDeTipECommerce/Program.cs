namespace AplicatieDeTipECommerce
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the details of your order.");
            Console.Write("Enter your name: ");
            string? customer = Console.ReadLine();
            Console.Write("Enter the amount of money you pay: ");
            string? totalAsString = Console.ReadLine();
            decimal total;
            bool isDecimal = decimal.TryParse(totalAsString, out decimal result);
            if (isDecimal)
            {
               total = result;
            }
            else
            {
                total = 0;
            }
            Console.WriteLine("The current date will be considered.");
            DateTime date = DateTime.Now;
            Order order = new Order(customer, date, total);
                Console.WriteLine("Please use one of the three methods listed right here: credit card, PayPal, crypto wallet");
                Console.Write("Enter the payment method you would like to use: ");
            string? paymentMethod = Console.ReadLine();
            if (paymentMethod != null)
            {
                if (paymentMethod == "credit card")
                {
                    OrderProcessor.FulfillOrder(order, new CreditCard(paymentMethod));
                }
                else if (paymentMethod == "PayPal")
                {
                    OrderProcessor.FulfillOrder(order, new PayPal(paymentMethod));
                }
                else if (paymentMethod == "crypto wallet")
                {
                    OrderProcessor.FulfillOrder(order, new CryptoWallet(paymentMethod));
                }
                else
                {
                    Console.WriteLine("Unknown payment method...");
                }
            }
            else 
            {
                Console.WriteLine("Cannot process a void transaction.");
            }
            
        }
    }
}
