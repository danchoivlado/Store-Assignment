using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Entities;
using Store.Entities.Products;

namespace Store.Core
{
    public class TestEngine
    {
        public void Run()
        {
            var cart = new Cart();
            var cashier = new Cashier();

            var food = new Food("apples", "BrandA", 1.5, new DateTime(2021, 06, 14));
            var beverage = new Beverage("milk", "BrandM", 0.99, new DateTime(2022, 02, 02));
            var clothes = new Clothes("T-shirt", "BrandT", 15.99, ClothesSize.M, "violet");
            var appliance = new Appliance("laptop", "BrandL", 2345, "ModelL", new DateTime(2021, 03, 03), 1.125);

            cart.AddProductToCart(2.45, food);
            cart.AddProductToCart(3, beverage);
            cart.AddProductToCart(2, clothes);
            cart.AddProductToCart(1, appliance);

            cashier.PrintRecipe(cart.GetCartProducts(), new DateTime(2021, 06, 14, 12, 34, 56));
        }
    }
}
