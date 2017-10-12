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
        public float calculatePrice(Ticket ticket)
        {
            int tariefeenheden = Tariefeenheden.getTariefeenheden(ticket.From, ticket.To);
            int tablecolumn;
            if (ticket.TClass == Class.FirstClass) tablecolumn = 3;
            else tablecolumn = 0;
            if (ticket.TDiscount == Discount.FortyDiscount) tablecolumn += 2;
            else if (ticket.TDiscount == Discount.TwentyDiscount) tablecolumn += 1;
            float price = PricingTable.getPrice(tariefeenheden, tablecolumn);
            if (ticket.TWay == Way.Return) price *= 2;
            if (ticket.TPayment == Payment.CreditCard) price += 0.5f;
            return price;
        }
        public void getPrice()
        {

        }
        //newpayment maakt een payment in de juiste vorm
        public void newPayment(float price,Ticket ticket)
        {
            if (ticket.TPayment == Payment.Cash)
            {
                PaymentMethod p = new Cashpayment(price);
            }
            if (ticket.TPayment == Payment.CreditCard)
            {
                PaymentMethod p = new Creditpayment(price);
            }
            if (ticket.TPayment == Payment.DebitCard)
            {
                PaymentMethod p = new Debitpayment(price);
            }
        }
    }
}
