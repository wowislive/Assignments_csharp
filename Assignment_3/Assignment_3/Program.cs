using System;
using System.Collections;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList concerts = new ArrayList();

            concerts.Add(new Concert("MyConcert1", "Vaasa", "13/09/2023", "08:15", 50.50));
            concerts.Add(new Concert("MyConcert2", "Seinajoki", "15/09/2023", "14:30", 105.99));
            concerts.Add(new Concert("MyConcert3", "Vaasa", "19/09/2023", "10:00", 70.00));
            concerts.Add(new Concert("MyConcert4", "Seinajoki", new DateTime(2023, 9, 25, 12, 30, 0), 15.15));
            concerts.Add(new Concert("MyConcert5", "Vaasa", new DateTime(2023, 10, 4, 8, 15, 0), 130.00));

            //create an instance of the ConcertComparer class
            ConcertComparer comparer = new ConcertComparer();

            //sort the 'concerts' list using the custom comparison logic provided by the 'comparer' instance
            concerts.Sort(comparer);

            //iterate through the sorted 'concerts' list and print each concert's details
            foreach (Concert concert in concerts)
            {
                Console.WriteLine(concert);
                Console.WriteLine();
            }

            //test other operators
            Concert testConcert = new Concert("This is a Test", "Test Location", DateTime.Now, 100.00);
            Console.WriteLine("Defined operators Test:");
            Console.WriteLine();
            Console.WriteLine(testConcert);
            Console.WriteLine();

            //one time plus 5 units
            Console.WriteLine("++ Test:");
            Console.WriteLine();
            Console.WriteLine(testConcert++);
            Console.WriteLine();

            //two times minus 5 units
            Console.WriteLine("-- Test:");
            Console.WriteLine();
            testConcert--;
            Console.WriteLine(testConcert--);
            Console.WriteLine();

            //create an identical object and check equality operators
            Console.WriteLine("== AND Equals Test:");
            Concert testConcert2 = testConcert;
            Console.WriteLine();
            //if the objects are equal, it will output True
            Console.WriteLine(testConcert2 == testConcert && testConcert.Equals(testConcert2));
        }
    }
}
