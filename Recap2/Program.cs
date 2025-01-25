using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace Recap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float value = 0;
            char unit;

            Console.WriteLine("| Temperature Converter |");

            Console.Write("Enter the temperature value: ");
            value = float.Parse(Console.ReadLine());
            Console.Write("Convert to Farenheith or Celsius (C or F): ");
            unit = char.Parse(Console.ReadLine().ToLower());

            while (unit != 'c' && unit != 'f')
            {
                Console.WriteLine("Wrong unit. Try again!");
                Console.Write("Convert to Farenheith or Celsius (C or F): ");
                unit = char.Parse(Console.ReadLine().ToLower());
            }

            Temperature temp = new Temperature(value, unit);

            if (unit == 'c')
            {
                temp.ConvertToFarenheit();
            }
            else
            {
                temp.ConvertToCelsius();
            }

            temp.DisplayResult();

            Console.WriteLine("============================================");


            List<Book> books = new List<Book>();

            books.Add(new Book("The Lord of The Rings", "J. R. R. Tolkien"));
            books.Add(new Book("Harry Potter And The Chambers of Secrets", "J. K. Rowling"));
            books.Add(new Book("Hunger Games", "Suzanne Collins"));

            foreach (var book in books)
            {
                book.DisplayDetails();
            }

            Console.WriteLine("Which book would you like to borrow (enter the title): ");
            string borrowBook = Console.ReadLine();

            Book bookBorrowed= books.Find(book => book.Title == borrowBook);

            bookBorrowed.IsAvailable = false;

            foreach (var book in books)
            {
                book.DisplayDetails();
            }

            Console.WriteLine("============================================");

            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            Employee emp1 = new Employee("Alice", 25) { Department = "HR" };
            Employee emp2 = new Employee("Bob", 30) { Department = "Engineering" };
            Employee emp3 = new Employee("Charlie", null) { Department = "Marketing" };

            employees.Add(emp1.Id, emp1);
            employees.Add(emp2.Id, emp2);
            employees.Add(emp3.Id, emp3);

            foreach(KeyValuePair<int, Employee> employee in employees)
            {
                employee.Value.ShowDetails();
            }

            Console.ReadKey();
        }
    }
}

