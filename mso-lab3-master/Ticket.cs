using System;

namespace Lab3
{
    public enum Class
    {
        FirstClass,
        SecondClass
    }

    public enum Way
    {
        OneWay,
        Return
    }

    public enum Discount
    {
        NoDiscount,
        TwentyDiscount,
        FortyDiscount
    }

    public enum Payment
    {
        DebitCard,
        CreditCard,
        Cash
    }

    public struct Ticket
    {
        string from, to;
        Class cls;
        Way way;
        Discount discount;
        Payment payment;
        DateTime date;

        public Ticket(string from, string to, Class cls, Way way, Discount discount, Payment payment)
        {
            this.from = from;
            this.to = to;
            this.cls = cls;
            this.way = way;
            this.discount = discount;
            this.payment = payment;
            date = DateTime.Now;
        }

        public string From {
            get {
                return from;
            }
        }

        public string To {
            get {
                return to;
            }
        }

        public Class TClass {
            get {
                return cls;
            }
        }

        public Way TWay {
            get {
                return way;
            }
        }

        public Discount TDiscount {
            get {
                return discount;
            }
        }

        public Payment TPayment {
            get {
                return payment;
            }
        }
        public DateTime Date { 
            get {
                return date;
                }
        }
	}
}

