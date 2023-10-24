using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentPattern
{
    class DebtCard : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine("mpho pays Rs " + amount+ "using DebtCard");
        }
    }
}
