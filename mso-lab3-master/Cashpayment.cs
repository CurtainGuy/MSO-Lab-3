using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    class Cashpayment : PaymentMethod
    {
        IKEAMyntAtare2000 coin;
        public Cashpayment(float price)
        {
            if (price == 0)
            {
                MessageBox.Show("Departure and destination are the same.");
                return;
            }
            coin = new IKEAMyntAtare2000();
            handlePayment(price);            
        }
        protected override void handlePayment(float price)
        {
            coin.starta();
            coin.betala((int)Math.Round(price * 100));
            coin.stoppa();
            base.handlePayment(price);
        }
    }
}
