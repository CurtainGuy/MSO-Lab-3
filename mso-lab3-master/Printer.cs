using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    class Printer
    {
        bool readytoPrint;
        
        public bool ReadytoPrint
        {
            get
            {
                return readytoPrint;
            }
        }

        public void printTicket(Ticket ticket)
        {
            MessageBox.Show("Ticket from " + ticket.From + " to " + ticket.To + ". We wish you a pleasant trip!");
        }
    }
}
