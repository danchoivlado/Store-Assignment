using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Entities.Products;

namespace Store.Core
{
    public class Cashier
    {
        public void PrintRecipe(Dictionary<double, Product> cart, DateTime timeOfPurchase)
        {
            Console.WriteLine($"Date: {timeOfPurchase.ToString("yyyy-MM-d hh:mm:ss")}");
            Console.WriteLine("---Products---");
            Console.WriteLine();

            var subtotal = 0d;
            var totalDiscount = 0d;
            foreach (var item in cart)
            {
                var product = item.Value;
                var quantity = item.Key;

                var discount = product.CalculateDiscount(timeOfPurchase);
                var totalPrice = quantity * product.Price;
                var discountInMoney = (totalPrice * discount) / 100;
                totalDiscount += discountInMoney;
                subtotal += totalPrice;

                Console.WriteLine($"{product.ToString()}");
                Console.WriteLine($"{quantity} x ${product.Price:F2} = ${(totalPrice):F2}");
                if (discount != 0)
                {
                    Console.WriteLine($"#discount {discount}% -${discountInMoney:F2}");
                }

                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 83));
            Console.WriteLine();
            Console.WriteLine($"SUBTOTAL: ${subtotal:F2}");
            Console.WriteLine($"DISCOUNT: -${totalDiscount:F2}");
            Console.WriteLine();
            Console.WriteLine($"TOTAL: ${(subtotal - totalDiscount):F2}");
        }
    }
}
