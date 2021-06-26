using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Entities.Contracts;

namespace Store.Entities.Products
{
    public class Food : Product, IPerishable
    {
        public DateTime ExpirationDate { get; private set; }

        public Food(string name, string brand, double price, DateTime expirationDate) : base(name, brand, price)
        {
            this.ExpirationDate = expirationDate;
        }

        public override int CalculateDiscount(DateTime timeOfPurchase)
        {
            if (timeOfPurchase.Date == ExpirationDate.Date)
            {
                return 50;
            }

            if ((ExpirationDate - timeOfPurchase).TotalDays <= 5)
            {
                return 10;
            }

            return 0;
        }
    }
}
