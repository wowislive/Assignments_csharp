using System;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an airline company
            AirlineCompany myAirline = new AirlineCompany("MyAirlines");

            // Add flights to the airline
            myAirline.Airlines.Add(new Flight(1, "New York", "Los Angeles", new DateTime(2023, 10, 15), 300.0), 300.0);
            myAirline.Airlines[new Flight(2, "Chicago", "Miami", new DateTime(2023, 10, 20), 250.0)] = 250.0;
            myAirline.Airlines[new Flight(3, "Dallas", "San Francisco", new DateTime(2023, 10, 25), 400.0)] = 400.0;

            // Find the cheapest flight
            Flight cheapestFlight = myAirline.GetCheapestFlight();

            Console.WriteLine($"Cheapest Flight: {cheapestFlight.Origin} to {cheapestFlight.Destination} on {cheapestFlight.Date.ToShortDateString()} for ${cheapestFlight.Price}");

            // Find the most expensive flight
            Flight mostExpensiveFlight = myAirline.GetMostExpensiveFlight();
            
            Console.WriteLine($"Most Expensive Flight: {mostExpensiveFlight.Origin} to {mostExpensiveFlight.Destination} on {mostExpensiveFlight.Date.ToShortDateString()} for ${mostExpensiveFlight.Price}");


            // Find a flight by ID
            int searchFlightId = 2;

            foreach (Flight key in myAirline.Airlines.Keys)
            {
                Console.WriteLine(key.FindFlight(searchFlightId));
            }

            // Print all flights in sorted order

            Console.WriteLine("Print all flights in sorted order: ");

            foreach (Flight key in myAirline.Airlines.Keys)
            {
                Console.WriteLine(key.ToString());
            }
        }
    }
}
