using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please select the Payment Type : Cash or DebtCard or CreditCard");
            string PaymentType = Console.ReadLine();

            Console.WriteLine("\nPlease enter Amount to Pay : ");
            double Amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Amount is : " + Amount);
            Context context = new Context();

            if ("CreditCard".Equals(PaymentType, StringComparison.InvariantCultureIgnoreCase))
            {
                context.SetpaymentStrategy(new CreditCard());
            }
            else if ("DebitCard".Equals(PaymentType, StringComparison.InvariantCultureIgnoreCase))
            {
                context.SetpaymentStrategy(new DebtCard());
            }
            else if ("Cash".Equals(PaymentType, StringComparison.InvariantCultureIgnoreCase))
            {
                context.SetpaymentStrategy(new Cash());
            }
            context.Pay(Amount);
            Console.ReadKey();

        }
    }
}
