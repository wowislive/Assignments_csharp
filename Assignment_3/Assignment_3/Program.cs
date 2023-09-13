using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList concerts = new ArrayList();

            concerts.Add(new Concert("This is title", "This is location", "13/09/2023", "08:15", 50.50));
            concerts.Add(new Concert("This is title", "This is location", "15/09/2023", "14:30", 105.99));
            concerts.Add(new Concert("This is title", "This is location", "19/09/2023", "10:00", 70.00));
            concerts.Add(new Concert("This is title2", "This is location2", new DateTime(2023, 9, 25, 12, 30, 0), 15.15));
            concerts.Add(new Concert("This is title2", "This is location2", new DateTime(2023, 10, 4, 8, 15, 0), 130.00));
        }
    }
}
