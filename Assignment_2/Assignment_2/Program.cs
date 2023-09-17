using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //use ArrayList because I don’t know how long the array will be
            ArrayList customers = new ArrayList();
            ArrayList purchases = new ArrayList();
            ArrayList purchaseIds = new ArrayList();
            bool anotherPurchase = true;
            bool anotherCustomer = true;
            bool anotherItem = true;
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
                    do
                    {
                        Console.Write("Type purchase ID: ");
                        int purchaseId = int.Parse(Console.ReadLine());
                        List<List<string>> twoDimensionalList = new List<List<string>>();
                        do
                        {
                            Console.Write("Type item: ");
                            string item = Console.ReadLine();
                            Console.Write("Type amount: ");
                            string amount = Console.ReadLine();
                            twoDimensionalList.Add(new List<string>() { item, amount });

                            Console.Write("Do you want to add another item? (yes/no): ");

                            if (Console.ReadLine().ToLower().Equals("no"))
                                anotherItem = false;

                        } while (anotherItem);

                        string[,] itemAndAmount = new string[twoDimensionalList.Count, 2];
                        for (int i = 0; i < twoDimensionalList.Count; i++)
                        {
                            for (int j = 0; j < 2; j++)
                                itemAndAmount[i, j] = twoDimensionalList[i][j];
                        }

                        purchaseIds.Add(purchaseId);
                        purchases.Add(new Purchase(shopName, purchaseId, itemAndAmount));

                        Console.Write("Do you want to add another item? (yes/no): ");

                        if (Console.ReadLine().ToLower().Equals("no"))
                            anotherPurchase = false;

                    } while (anotherPurchase);

                    customers.Add(new Customer(name, (int[])purchaseIds.ToArray(typeof(int))));

                    Console.Write("Do you want to add another customer? (yes/no): ");

                    if (Console.ReadLine().ToLower().Equals("no"))
                        anotherCustomer = false;
                }
                while (anotherCustomer);

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
