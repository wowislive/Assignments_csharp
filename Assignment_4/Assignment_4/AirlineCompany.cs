using System.Collections.Generic;
using System.Linq;


namespace Assignment_4
{
    internal class AirlineCompany
    {
        readonly string airlineName;
        readonly SortedList<Flight, double> airlines = new SortedList<Flight, double>();

        public AirlineCompany(string name)
        {
            airlineName = name;
        }

        public string AirlineName
        { get { return airlineName; } }

        public SortedList<Flight, double> Airlines
        { get { return airlines; } }

        public double this[Flight flight]
        {
            get
            {
                return airlines[flight];
            }
            set
            {
                airlines[flight] = value;
            }
        }

        public Flight GetCheapestFlight()
        {
            Flight cheapestFlight = airlines.First().Key;
            return cheapestFlight;
        }

        public Flight GetMostExpensiveFlight()
        {
            Flight mostExpensiveFlight = airlines.Last().Key;
            return mostExpensiveFlight;
        }

    }
}
