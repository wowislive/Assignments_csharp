using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //use ArrayList because I don’t know how long the array will be
            ArrayList customers = new ArrayList();
            ArrayList purchases = new ArrayList();

            try
            {
                Console.WriteLine("1. Test mode");
                Console.WriteLine("2. Manual mode");
                Console.Write("Enter the number of the selected mode: ");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        // Code to run the program in test mode
                        Console.WriteLine("The program is running in test mode.");

                        // Add some customers and purchases for testing
                        customers.Add(new Customer("Mike", new int[] { 111, 222 }));
                        customers.Add(new Customer("John", new int[] { 333, 444 }));
                        customers.Add(new Customer("Kyle", new int[] { 555 }));
                        purchases.Add(new Purchase("MyShop", 111, new string[,] { { "Water", "2" }, { "Bread", "1" } }));
                        purchases.Add(new Purchase("MyShop", 222, new string[,] { { "Beer", "3" }, { "Burger", "1" } }));
                        purchases.Add(new Purchase("ShopNumTwo", 333, new string[,] { { "Something", "10" }, { "anything else", "1" } }));
                        purchases.Add(new Purchase("ShopNumTwo", 444, new string[,] { { "Something", "20" }, { "anything else", "30" } }));
                        purchases.Add(new Purchase("Third", 555, new string[,] { { "Smt", "0" }, { "Any", "0" } }));

                        break;

                    case 2:
                        // Code to run the program in manual mode
                        Console.WriteLine("The program is running in manual mode.");

                        bool anotherPurchase = true;
                        bool anotherCustomer = true;
                        bool anotherItem = true;

                        do
                        {
                            //array for all purchase IDs of one customer
                            ArrayList purchaseIds = new ArrayList();

                            Console.Write("Type customer name: ");
                            string name = Console.ReadLine();
                            Console.Write("Type shop name: ");
                            string shopName = Console.ReadLine();
                            do
                            {
                                Console.Write("Type purchase ID: ");
                                int purchaseId = int.Parse(Console.ReadLine());

                                //create a List that is then transformed into a two-dimensional array
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
                                    else
                                        anotherItem = true;

                                } while (anotherItem);

                                //transform a list of lists into a two-dimensional array
                                string[,] itemAndAmount = new string[twoDimensionalList.Count, 2];
                                for (int i = 0; i < twoDimensionalList.Count; i++)
                                {
                                    for (int j = 0; j < 2; j++)
                                        itemAndAmount[i, j] = twoDimensionalList[i][j];
                                }

                                purchaseIds.Add(purchaseId);
                                purchases.Add(new Purchase(shopName, purchaseId, itemAndAmount));

                                Console.Write("Do you want to add another purchase? (yes/no): ");

                                if (Console.ReadLine().ToLower().Equals("no"))
                                    anotherPurchase = false;
                                else
                                    anotherPurchase = true;

                            } while (anotherPurchase);

                            customers.Add(new Customer(name, (int[])purchaseIds.ToArray(typeof(int))));

                            Console.Write("Do you want to add another customer? (yes/no): ");

                            if (Console.ReadLine().ToLower().Equals("no"))
                                anotherCustomer = false;
                            else
                                anotherCustomer = true;
                        }
                        while (anotherCustomer);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. The program is exiting.");
                        break;
                }

                //CustomerPurchaseHandler class accepts two arrays as arguments, so I cast the ArrayList as an array
                CustomerPurchaseHandler cusPurHandler =
                    new CustomerPurchaseHandler((Customer[])customers.ToArray(typeof(Customer)), (Purchase[])purchases.ToArray(typeof(Purchase)));

                //loop to be able to search again
                bool anotherSearch = true;
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
