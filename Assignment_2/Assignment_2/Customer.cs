using System;

namespace Assignment_2
{
    class Customer
    {
        string name;
        int customerId;
        int[] purchaseIds;
        static int nextId = 1;

        public Customer(string name, int[] purchaseIds)
        {
            this.name = name;
            this.purchaseIds = purchaseIds;
            customerId = nextId;
            nextId++;
        }

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
