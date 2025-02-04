using System.Diagnostics;

namespace ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            Debug.WriteLine("Main Method is running");

            try
            {
                Console.Write("Please enter a number: ");
                int num1 = int.Parse(Console.ReadLine());

                int num2 = 2;

                result = num1 / num2;

                Console.WriteLine($"Result: {result}");
            }
            catch(Exception e) {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                // Code to cleanup or finalize,
                // ideal for cleaning up resources,
                // like closing file streams or database connection.
                Console.WriteLine("This always executes");
            }

            Console.ReadKey();
        }
    }
}
