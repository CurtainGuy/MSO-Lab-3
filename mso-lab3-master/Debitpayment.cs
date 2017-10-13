using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    class Debitpayment : PaymentMethod
    {
        DebitCard d;
        
        public Debitpayment(float price)
        {
            if (price == 0)
            {
                MessageBox.Show("Departure and destination are the same.");
                return;
            }
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
