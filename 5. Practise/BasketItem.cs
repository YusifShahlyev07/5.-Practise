using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Practise
{
    internal class BasketItem
    {
        public BasketItem(Product? productItem, int count)
        {
            ProductItem = productItem;
            Count = count;
        }

        public Product? ProductItem { get; set; }
        public int Count { get; set; }

        public void ShowItem()
        {
            if (ProductItem == null)
            {
                Console.WriteLine("No Item");
            }
            else
            {
                ProductItem.Show();
                Console.WriteLine($"Count: {Count}");
            }
        }
    }
}
