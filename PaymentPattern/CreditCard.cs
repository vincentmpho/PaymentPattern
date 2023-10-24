using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentPattern
{
     class CreditCard : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine(" vin pays rs" + amount + "using CreditCard");
        }
    }
}
