using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentPattern
{
     class Context
    {
        private IPayment paymentStrategy;
        
        public void SetpaymentStrategy(IPayment Strategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void Pay(double amount)
        {
            paymentStrategy.Pay( amount);
        }
    }
}
