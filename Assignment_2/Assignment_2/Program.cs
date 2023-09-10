using System;
using System.Collections;
using System.Text;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList customers = new ArrayList();
            ArrayList purchases = new ArrayList();

            try
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

                CustomerPurchaseHandler cusPurHandler =
                    new CustomerPurchaseHandler((Customer[])customers.ToArray(typeof(Customer)), (Purchase[])purchases.ToArray(typeof(Purchase)));

                Console.Write("Search by customer name: ");
                string searchName = Console.ReadLine();
                Console.WriteLine(cusPurHandler.Search(searchName));

                Console.Write("Search by purchase ID: ");
                int searchId = int.Parse(Console.ReadLine());
                Console.WriteLine(cusPurHandler.Search(searchId));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalide data type!" + Environment.NewLine + e.Message);
            }
        }
    }
}
