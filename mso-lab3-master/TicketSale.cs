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
        public void calculatePrice(UIInfo ticket)
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
        }
        public void getPrice()
        {

        }
        public void newPayment(float price)
        {
            Payment p = new Payment(price);
        }
    }
}
