using System;

namespace Assignment_2
{
    class Purchase
    {
        DateTime purchaseDate;
        string shopName;
        int purchaseId;
        string[,] itemAndAmount;

        public Purchase(string shopName, int purchaseId, string[,] itemAndAmount)
        {
            purchaseDate = DateTime.Now;
            this.shopName = shopName;
            this.purchaseId = purchaseId;
            this.itemAndAmount = itemAndAmount;
        }

        public bool PurchaseFound(int purchaseId)
        {
            if (this.purchaseId == purchaseId)
                return true;
            return false;
        }

        public override string ToString()
        {
            string fullString = "Date: " + purchaseDate +
                Environment.NewLine + "Shop name: " + shopName +
                Environment.NewLine + "Purchase ID: #" + purchaseId + Environment.NewLine;

            for (int i = 0; i < itemAndAmount.GetLength(0); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    fullString += " " + itemAndAmount[i, j];
                }
                fullString += Environment.NewLine;
            }

            return fullString;
        }
    }
}
