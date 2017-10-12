using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Creditpayment : PaymentMethod
    {
        public Creditpayment(float price)
        {
            CreditCard c = new CreditCard();
            c.Connect();
            int ccid = c.BeginTransaction(price);
            c.EndTransaction(ccid);
            ispaymentdone = true;
        }
    }
}
