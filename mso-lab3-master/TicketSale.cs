using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class TicketSale
    {

        //calculatePrice calculates the price using the information form ticket, it checks Tariefeenheden and the PricingTable.     
        int tariefeenheden;
        int tablecolumn;
        //calculate the price and call getTablecolumns()
        public float calculatePrice(Ticket ticket)
        {
            tariefeenheden = Tariefeenheden.getTariefeenheden(ticket.From, ticket.To);
            getTablecolumns(ticket);            
            float price = PricingTable.getPrice(tariefeenheden, tablecolumn);
            if (ticket.TWay == Way.Return) price *= 2;
            if (ticket.TPayment == Payment.CreditCard) price += 0.5f;
            return price;
        }
        //calculates the tablecolumns
        public void getTablecolumns(Ticket ticket)
        {
            if (ticket.TClass == Class.FirstClass) tablecolumn = 3;
            else tablecolumn = 0;
            if (ticket.TDiscount == Discount.FortyDiscount) tablecolumn += 2;
            else if (ticket.TDiscount == Discount.TwentyDiscount) tablecolumn += 1;
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
