using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Entities.Products
{
    public class Appliance : Product
    {
        public string Model { get; private set; }

        public DateTime ProductionDate { get; private set; }

        public double Weight { get; private set; }

        public Appliance(string name, string brand, double price, string model,
            DateTime productionDate, double weight) : base(name, brand, price)
        {
            this.Model = model;
            this.ProductionDate = productionDate;
            this.Weight = weight;
        }

        public override int CalculateDiscount(DateTime timeOfPurchase)
        {
            bool isBoughtOnWeekend = base.IsBoughtOnWeekend(timeOfPurchase);

            if (isBoughtOnWeekend && base.Price > 999)
            {
                return 5;
            }

            return 0;
        }

        public override string ToString()
        {
            return base.ToString() + $" {this.Model}";
        }
    }
}
