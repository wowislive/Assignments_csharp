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
