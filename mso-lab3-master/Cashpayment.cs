using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Cashpayment : PaymentMethod
    {
        public Cashpayment(float price)
        {
            IKEAMyntAtare2000 coin = new IKEAMyntAtare2000();
            coin.starta();
            coin.betala((int)Math.Round(price * 100));
            coin.stoppa();
            ispaymentdone = true;
        }        
    }
}
