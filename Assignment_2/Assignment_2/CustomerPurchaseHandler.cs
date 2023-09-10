using System;
using System.Text;

namespace Assignment_2
{
    class CustomerPurchaseHandler
    {
        static Customer[] customers;
        static Purchase[] purchases;
        public CustomerPurchaseHandler(Customer[] customers, Purchase[] purchases)
        {
            CustomerPurchaseHandler.customers = customers;
            CustomerPurchaseHandler.purchases = purchases;
        }

        public string Search(string name)
        {
            StringBuilder result = new StringBuilder();
            bool isFound = false;
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i].CustomerFound(name))
                {
                    isFound = true;
                    result.AppendLine("Customer with name " + name + " found." + Environment.NewLine + customers[i].ToString() + 
                        Environment.NewLine + purchases[i].ToString());
                }
            }
            if (!isFound)
                result.AppendLine("Customer with name " + name + " was not found!");
            return result.ToString();
        }

        public string Search(int purchaseId)
        {
            StringBuilder result = new StringBuilder();
            bool isFound = false;
            for (int i = 0; i < purchases.Length; i++)
            {
                if (purchases[i].PurchaseFound(purchaseId))
                {
                    isFound = true;
                    result.AppendLine("Purchase with ID " + purchaseId + " found." + Environment.NewLine + customers[i].ToString() + 
                        Environment.NewLine + purchases[i].ToString());
                }
            }
            if (!isFound)
                result.AppendLine("Purchase with ID " + purchaseId + " was not found!");
            return result.ToString();
        }
    }
}
