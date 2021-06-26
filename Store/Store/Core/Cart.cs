using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Entities.Products;

namespace Store.Core
{
    public class Cart
    {
        private Dictionary<double, Product> products;

        public Cart()
        {
            this.products = new Dictionary<double, Product>();
        }

        public void AddProductToCart(double quantity, Product product)
        {
            this.products.Add(quantity, product);
        }

        public Dictionary<double, Product> GetCartProducts()
        {
            return this.products;
        }
    }
}
