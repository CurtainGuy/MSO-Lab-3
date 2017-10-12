using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    abstract class PaymentMethod
    {
        protected bool ispaymentdone;
        
        protected virtual void handlePayment(float price)
        {
            ispaymentdone = true;
        }
    }
}
