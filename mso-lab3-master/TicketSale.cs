using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class TicketSale
    {
        
        //calculatePrice calculates the price using the information form ticket, it checks Tariefeenheden and the PricingTable.
        //mogen we dingen in UIinfo aanpassen?
        //ik zit er over te denken om calculateprice op te splitsen, dan worden de methodes wat korter.
        public float calculatePrice(UIInfo ticket)
        {
            int tariefeenheden = Tariefeenheden.getTariefeenheden(ticket.From, ticket.To);
            int tablecolumn;
            if (ticket.Class == UIClass.FirstClass) tablecolumn = 3;
            else tablecolumn = 0;
            if (ticket.Discount == UIDiscount.FortyDiscount) tablecolumn += 2;
            else tablecolumn += 1;
            float price = PricingTable.getPrice(tariefeenheden, tablecolumn);
            if (ticket.Way == UIWay.Return) price *= 2;
            if (ticket.Payment == UIPayment.CreditCard) price += 1;
            return price;
        }
        public void getPrice()
        {

        }
        //newpayment maakt een payment in de juiste vorm
        public void newPayment(float price,UIInfo ticket)
        {
            if (ticket.Payment == UIPayment.Cash)
            {
                Payment p = new Cashpayment(price);
            }
            if (ticket.Payment == UIPayment.CreditCard)
            {
                Payment p = new Creditpayment(price);
            }
            if (ticket.Payment == UIPayment.DebitCard)
            {
                Payment p = new Debitpayment(price);
            }
        }
    }
}
