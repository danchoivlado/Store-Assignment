using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Entities.Products
{
    public abstract class Product
    {
        public string Name { get; protected set; }

        public string Brand { get; protected set; }

        public double Price { get; protected set; }

        public abstract int CalculateDiscount(DateTime timeOfPurchase);

        protected Product(string name, string brand, double price)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
        }

        protected bool IsBoughtOnWeekend(DateTime timeOfPurchase)
        {
            if (timeOfPurchase.DayOfWeek != DayOfWeek.Saturday && timeOfPurchase.DayOfWeek != DayOfWeek.Sunday)
                return false;
            else
                return true;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Brand}";
        }
    }
}
