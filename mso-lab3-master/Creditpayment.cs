using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Creditpayment : PaymentMethod
    {
        CreditCard c;

        public Creditpayment(float price)
        {
            c = new CreditCard();
            handlePayment(price);
        }

        protected override void handlePayment(float price)
        {
            c.Connect();
            int ccid = c.BeginTransaction(price);
            c.EndTransaction(ccid);
            base.handlePayment(price);
        }
    }
}
