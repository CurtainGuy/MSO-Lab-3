using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Debitpayment : PaymentMethod
    {
        DebitCard d;
        
        public Debitpayment(float price)
        {            
			d = new DebitCard();
            handlePayment(price);
        }

        protected override void handlePayment(float price)
        {
            d.Connect();
            int dcid = d.BeginTransaction(price);
            d.EndTransaction(dcid);
            base.handlePayment(price);
        }
    }
}
