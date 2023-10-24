using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentPattern
{
    interface IPayment
    {
        void Pay(double amount);
    }
}
