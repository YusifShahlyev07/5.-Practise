using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _5._Practise
{
    internal class Product
    {
        private static int static_id = 1000;

        public int ID { get; }
        public string? Name { get; set; }
        public double  Price { get; set; }
        public DateTime ExpireDate { get; set; }
        public Product()
        {
            static_id++;
            ID = static_id;
            Name = "None";
            Price = 0;
            ExpireDate = DateTime.Now.AddDays(15);
        }

        public Product( string? name, double price, DateTime expireDate):this()
        {
            Name = name;
            Price = price;
            ExpireDate = expireDate;
        }

        public void Show()
        {
            if (ExpireDate < DateTime.Now)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            RegionInfo aze = new RegionInfo("az-AZ");
            Console.WriteLine($"ID: {this.ID}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Price: {this.Price} {aze.CurrencySymbol}");
            Console.WriteLine($"Exp-Date: {this.ExpireDate}");
            Console.ResetColor();
        }
    }
}
