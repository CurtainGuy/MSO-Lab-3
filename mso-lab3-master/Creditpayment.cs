using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    class Creditpayment : PaymentMethod
    {
        CreditCard c;

        public Creditpayment(float price)
        {
            if (price == 0.5f)
            {
                MessageBox.Show("Departure and destination are the same.");
                return;
            }
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
