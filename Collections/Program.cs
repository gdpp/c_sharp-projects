using System.Globalization;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Juan");
            names.Add("Pablo");
            names.Add("Gus");
            names.Add("Sam");
            names.Add("Jack");
            names.Add("Tenorio");
            names.Add("Tenorio");
            names.Add("Tenorio");
            names.Add("Tenorio");

            foreach (string name in names)
            {
                Console.WriteLine("Current name: " + name);
            }

            names.Remove("Juan");

            bool isDeletedSuccesful = names.Remove("Tenorio");

            while (isDeletedSuccesful)
            {
                isDeletedSuccesful = names.Remove("Tenorio");
            }

            List<string> colors = [
                "red",
                "blue",
                "green"
            ];

            List<int> numbers = new List<int>{10, 5, 15, 3, 9, 15, 80, 2};

            Console.WriteLine("Unsorted List:");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();

            Console.WriteLine("Sorted List:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Lambda expresion consist of 2 parts:
            // 1. Parameters
            // 2. Expression of statement block

            // Parameters are written on the left side of =>
            // (this symbol is read as "becomes")
            // the expression or action to perform is on the right side

            // x => x * x

            // Returns a boolean value
            Predicate<int> isGreaterThanTen = x => x >= 10;

            List<int> filteredNumbers = numbers.FindAll(isGreaterThanTen);

            bool hasLargeNumber = numbers.Any(x => x > 50);

            foreach (int number in filteredNumbers)
            {
                Console.WriteLine(number);
            }


            List<Product> products = new List<Product>{
               new Product { Name = "Monitor H666", Price = 399.99 },
               new Product { Name = "RJ45 Cable", Price = 1.99 },
               new Product { Name = "Mechanical Keyboard G007", Price = 199.99 }
            };

            products.Add(new Product
                {
                    Name = "Mouse L90", 
                    Price = 89.99
                }
            );

            Console.WriteLine("Available products: ");

            foreach(Product product in products)
            {
                Console.Write($"{product.Name} - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"${product.Price}");
                Console.ResetColor();
            }

            // Key - value
            Dictionary<int, string> employees = new Dictionary<int, string>();

            employees.Add(101, "Jhon Doe");
            employees.Add(102, "Mikael Ostman");
            employees.Add(103, "Gustavo Perez");
            employees.Add(104, "Geovanni Espinoza");

            string name = employees[101];

            Console.WriteLine(name);

            employees[102] = "Michael Garret";
            
            employees.Remove(101);


            foreach(KeyValuePair<int,String> employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }

            Console.ReadKey();
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

    }
}
