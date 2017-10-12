using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Cashpayment : PaymentMethod
    {
        IKEAMyntAtare2000 coin;
        public Cashpayment(float price)
        {
            coin = new IKEAMyntAtare2000();
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
