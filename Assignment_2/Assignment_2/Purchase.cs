using System;

namespace Assignment_2
{
    class Purchase
    {
        DateTime purchaseDate;
        string shopName;
        int purchaseId;
        int amount;

        public Purchase(string shopName, int purchaseId, int amount)
        { 
            purchaseDate = DateTime.Now;
            this.shopName = shopName;
            this.purchaseId = purchaseId;
            this.amount = amount;
        }

        public bool PurchaseFound(int purchaseId)
        {
            if (this.purchaseId == purchaseId)
                return true;
            return false;
        }

        public override string ToString()
        {
            return "Date: " + purchaseDate + Environment.NewLine + "Shop name: " + shopName + 
                Environment.NewLine + "Purchase ID: #" + purchaseId + Environment.NewLine + "Amount: " + amount;
        }
    }
}
