using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Entities.Products
{
    public class Clothes : Product
    {
        public ClothesSize Size { get; private set; }

        public string Color { get; private set; }

        public Clothes(string name, string brand, double price, ClothesSize size, string color) : base(name, brand, price)
        {
            this.Size = size;
            this.Color = color;
        }

        public override int CalculateDiscount(DateTime timeOfPurchase)
        {
            bool isBoughtOnWeekend = base.IsBoughtOnWeekend(timeOfPurchase);

            if (isBoughtOnWeekend)
            {
                return 0;
            }

            return 10;
        }

        public override string ToString()
        {
            return base.ToString() + $" {this.Size} {this.Color}";
        }
    }
}
