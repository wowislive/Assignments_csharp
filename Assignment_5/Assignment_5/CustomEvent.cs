using System;

namespace Assignment_5
{
    public class CustomEvent
    {
        readonly private string name;
        private string type;
        private string location;
        private DateTime date;
        private double price;

        public CustomEvent()
        {
        }

        public CustomEvent(string name, string type, string location, DateTime date, double price)
        {
            this.name = name;
            this.Type = type;
            this.Location = location;
            this.Date = date;
            this.Price = price;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Type: {Type}, Location: {Location}, Date: {Date}, Price: {Price}";
        }

    }
}
