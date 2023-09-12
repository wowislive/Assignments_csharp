using System;
using System.Collections;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //use ArrayList because I don’t know how long the array will be
            ArrayList customers = new ArrayList();
            ArrayList purchases = new ArrayList();
            bool anotherPurchase = true;
            bool anotherSearch = true;

            try
            {
                //loop for adding a new purchase
                do
                {
                    Console.Write("Type customer name: ");
                    string name = Console.ReadLine();
                    Console.Write("Type shop name: ");
                    string shopName = Console.ReadLine();
                    Console.Write("Type purchase ID: ");
                    int purchaseId = int.Parse(Console.ReadLine());
                    Console.Write("Type amount: ");
                    int amount = int.Parse(Console.ReadLine());

                    customers.Add(new Customer(name, purchaseId));
                    purchases.Add(new Purchase(shopName, purchaseId, amount));

                    Console.Write("Do you want to add another customer? (yes/no): ");
                    string answer = Console.ReadLine().ToLower();

                    if (answer.Equals("no"))
                        anotherPurchase = false;
                } 
                while (anotherPurchase);

                //CustomerPurchaseHandler class accepts two arrays as arguments, so I cast the ArrayList as an array
                CustomerPurchaseHandler cusPurHandler =
                    new CustomerPurchaseHandler((Customer[])customers.ToArray(typeof(Customer)), (Purchase[])purchases.ToArray(typeof(Purchase)));

                //loop to be able to search again
                do
                {
                    Console.Write("Search by customer name: ");
                    string searchName = Console.ReadLine();
                    Console.WriteLine(cusPurHandler.Search(searchName));

                    Console.Write("Search by purchase ID: ");
                    int searchId = int.Parse(Console.ReadLine());
                    Console.WriteLine(cusPurHandler.Search(searchId));

                    Console.Write("Do you want to do another search? (yes/no): ");
                    string answer = Console.ReadLine().ToLower();

                    if (answer.Equals("no"))
                        anotherSearch = false;
                } 
                while (anotherSearch);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalide data type!" + Environment.NewLine + e.Message);
            }
        }
    }
}
