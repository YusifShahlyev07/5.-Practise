namespace _5._Practise
{
    #region list
    //class Person
    //{
    //    public Person(string? name)
    //    {
    //        Name = name;
    //    }

    //    public string? Name { get; set; }
    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //List<string> list = new List<string>();
    //list.Add("Leyla");
    //list.Add("Orxan");
    //list.Add("Ayxan");

    ////List<string> list2 = list;

    //List<string> list2 = list.ToList();
    //list2[0] = "Nuray";

    //foreach (var item in list)
    //{
    //    Console.WriteLine(item);
    //}


    //List<Person> list = new List<Person>();
    //list.Add(new Person("Leyla"));
    //list.Add(new Person("Orxan"));
    //list.Add(new Person("Ayxan"));

    ////List<string> list2 = list;

    //List<Person> list2 = list.ToList();
    ////list2[0].Name = "N";
    ////list2[0] = new Person("Ayxan");

    //foreach (var item in list)
    //{
    //    Console.WriteLine(item.Name);
    //}
    //    }
    //}
    #endregion

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Basket basket = new Basket();
            basket.AddProduct(new Product("milla", 2.3, new DateTime(2025, 11, 19)), 10);
            basket.AddProduct(new Product("yogurt", 1, new DateTime(2026, 11, 22)), 13);
            while (true)
            {
                Console.WriteLine(@"Show basket (S)
Add Product (A)
Delete Product (D)
Exit (E)
Choice: ");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.S)
                {
                    basket.ShowBasket();
                }
                else if (key.Key == ConsoleKey.A)
                {
                    Console.Write("Product name: ");
                    string p_name = Console.ReadLine();
                    Console.Write("Product price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Expired date: ");
                    int year = int.Parse(Console.ReadLine());
                    int month = int.Parse(Console.ReadLine());
                    int day = int.Parse(Console.ReadLine());

                    var datetime = new DateTime(year, month, day);
                    Product p = new Product(p_name,price,datetime);
                    Console.WriteLine("Count: ");
                    int count = int.Parse(Console.ReadLine());
                    basket.AddProduct(p,count);
                }
                else if (key.Key == ConsoleKey.D)
                {
                    Console.Write("Enter ID: ");
                    int.TryParse(Console.ReadLine(), out int id);
                    basket.RemoveProduct(id);
                }
                else if (key.Key == ConsoleKey.E)
                {
                    Console.WriteLine("Program finished");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
    }
}
