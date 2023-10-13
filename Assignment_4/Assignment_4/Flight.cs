using System;
using System.Text;

internal class Flight : IComparable
{
    int id;
    string origin;
    string destination;
    DateTime date;
    double price;

    public Flight()
    {
    }

    public Flight(int id, string origin, string destination, DateTime date, double price)
    {
        this.id = id;
        this.origin = origin;
        this.destination = destination;
        this.date = date;
        this.price = price;
    }

    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }

    public string Origin
    {
        get
        {
            return origin;
        }
        set
        {
            origin = value;
        }
    }

    public string Destination
    {
        get
        {
            return destination;
        }
        set
        {
            destination = value;
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

    public string FindFlight(int searchedId)
    {
        StringBuilder stringBuilder = new StringBuilder();
        if (Id == searchedId)
            stringBuilder.Append(Environment.NewLine + "Flight was founded" + Environment.NewLine + ToString());

        return stringBuilder.ToString();
    }

    public int CompareTo(object obj)
    {
        if (obj == null)
            return 0;
        if (obj is Flight)
        {
            Flight temp = (Flight)obj;
            if (this.Price > temp.Price)
                return 1;
            else if (this.Price < temp.Price)
                return -1;
            return 0;
        }
        return 0;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Flight ID: " + Id + Environment.NewLine);
        stringBuilder.Append("Origin: " + Origin + Environment.NewLine);
        stringBuilder.Append("Destination: " + Destination + Environment.NewLine);
        stringBuilder.Append("Date: " + Date.ToString("yyyy-MM-dd") + Environment.NewLine);
        stringBuilder.Append("Price: $" + Price.ToString("0.00") + Environment.NewLine);

        return stringBuilder.ToString();
    }
}
