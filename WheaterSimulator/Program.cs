namespace WheaterSimulator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the number of days to simulate: ");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = ["Sunny", "Rainy", "Cloudy", "Snowy"];
            string[] wheaterConditions = new string[days];

            Random random = new Random();

            Console.WriteLine("Getting temperatures...");

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                wheaterConditions[i] = conditions[random.Next(conditions.Length)];
                Console.WriteLine($"{i + 1} of {temperature.Length} obtained..");
            }

            
            Console.WriteLine("The averaga temperature is: " + CalculateAverage(temperature));
            Console.WriteLine("The minimum temperature was: " + temperature.Min());
            Console.WriteLine("The maximum temperature was: " + temperature.Max());
            Console.WriteLine($"Most common condition is: {MostCommonCondition(wheaterConditions)}");

            Console.ReadKey();
        }

        static double CalculateAverage(int[] temperature)
        {
            int sum = 0;

            foreach (int i in temperature) { 
                sum += i;
            }

            return sum / temperature.Length;
        }

        static int MinTemperature(int[] temperature)
        {
            int min = temperature[0];

            foreach (int temp in temperature)
            {
                if (temp < min)
                {
                    min = temp;
                }
            }

            return min;
        }

        static int MaxTemperature(int[] temperature)
        {
            int max = temperature[0];

            foreach (int temp in temperature)
            {
                if (temp > max)
                {
                    max = temp;
                }
            }

            return max;
        }

        static string MostCommonCondition(string[] conditions) { 
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;

                for(int j = 0; j < conditions[i].Length; j++)
                {
                    if (conditions[j] == conditions[i]){
                        tempCount++;
                    }
                }

                if(tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }

            return mostCommon;
        }
    }
}
