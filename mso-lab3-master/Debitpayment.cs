using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Debitpayment : PaymentMethod
    {
        public Debitpayment(float price)
        {            
			DebitCard d = new DebitCard();
            d.Connect();
            int dcid = d.BeginTransaction(price);
            d.EndTransaction(dcid);
            ispaymentdone = true;
        }
    }
}
