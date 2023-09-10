using System;

namespace Assignment_2
{
    class Customer
    {
        string name;
        int customerId;
        int purchaseId;
        static int nextId = 1;

        public Customer(string name, int purchaseId) 
        { 
            this.name = name;
            this.purchaseId = purchaseId;
            customerId = nextId;
            nextId++;
        }

        public int GetPurchaseId() { return purchaseId;}

        public bool CustomerFound(string name)
        {
            if (this.name.Equals(name))
                return true;
            return false;
        }

        public override string ToString()
        {
            return "Customer ID: #" + customerId + Environment.NewLine + "Name: " + name;
        }
    }
}
