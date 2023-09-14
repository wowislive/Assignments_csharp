using System;

namespace Assignment_3
{
    class Concert
    {
        string title;
        string location;
        string date;
        string time;
        double price;

        public Concert(string title, string location, string date, string time, double price)
        {
            this.title = title;
            this.location = location;
            this.date = date;
            this.time = time;
            this.price = price;
        }

        public Concert(string title, string location, DateTime concertDate, double price)
        {
            this.title = title;
            this.location = location;
            date = concertDate.ToString("dd.MM.yyyy");
            time = concertDate.ToString("HH:mm");
            this.price = price;
        }

        //Here we define == operator for the class
        public static bool operator ==(Concert c1, Concert c2)
        {
            if (c1.title.Equals(c2.title) && c1.price == c2.price)
                return true;
            return false;
        }

        //Here we define != operator for the class
        public static bool operator !=(Concert c1, Concert c2)
        {
            if (!(c1.title.Equals(c2.title) && c1.price == c2.price))
                return true;
            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Concert c = obj as Concert;

            if ((object)c == null)
            {
                return false;
            }
            if (this.price == c.price && this.title.Equals(c.title) && this.date.Equals(c.date))
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //Here we define < operator for the class
        public static bool operator <(Concert c1, Concert c2)
        {
            if (c1.price < c2.price)
                return true;
            return false;
        }

        //Here we define > operator for the class
        public static bool operator >(Concert c1, Concert c2)
        {
            if (c1.price > c2.price)
                return true;
            return false;
        }

        //Here we define ++ operator for the class
        public static Concert operator ++(Concert c1)
        {
            c1.price += 5.00;

            return c1;
        }

        //Here we define -- operator for the class
        public static Concert operator --(Concert c1)
        {
            c1.price -= (double)5.00;

            return c1;
        }

        public override string ToString()
        {
            return "Title: " + title + 
                Environment.NewLine + "Location: " + location + 
                Environment.NewLine + "Date: " + date + 
                Environment.NewLine + "Time: " + time + 
                Environment.NewLine + "Price: " + price.ToString("0.00") + "$";
        }
    }
}
