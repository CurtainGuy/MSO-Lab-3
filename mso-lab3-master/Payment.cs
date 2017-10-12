using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    abstract class Payment
    {
        float price;
        protected bool ispaymentdone;
        
        public virtual void handlePayment(float price)
        {
            ispaymentdone = true;
        }
    }
}
