using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Practise
{
    internal class Basket
    {
        public List<BasketItem> products { get; set; } = new List<BasketItem>();

        public void ShowBasket()
        {
            foreach (var item in products)
            {
                Console.WriteLine("🌭🌭🌭🌭🌭🌭🌭🌭🌭🌭🌭");
                item.ShowItem();
                Console.WriteLine("🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔");
            }
        }
        public void AddProduct(Product new_product, int count)
        {
             foreach (var item in products)
            {
                if (item.ProductItem.ID == new_product.ID)
                {
                    item.Count += count;
                }
            }
            var basket_item = new BasketItem(new_product,count);
            products.Add(basket_item);
        }

        public void RemoveProduct(int ID)
        {
            foreach (var item in products)
            {
                if (item.ProductItem.ID == ID)
                {
                    products.Remove(item);
                    return;
                }
            }
            throw new Exception("Product not found...");
        }
    }
}
