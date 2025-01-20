using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Recap1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Easy Exercise: Basic Arithmetic and User Input
            var result = Sequence();
            Console.WriteLine(result);

            // Intermediate Exercise: Analyze an Array of Numbers
            ManipulateArray();

            // Difficult Exercise: Guess the Number Game
            GuessTheNumber();

            Console.ReadKey();
        }

        static float Sequence() 
        {
            // Description:
            // Write a program that asks the user to enter two numbers. Perform the following operations and display the results:
            // - Add the numbers.
            // - Subtract the second number from the first.
            // - Multiply the numbers.
            // - Divide the first number by the second.
            
            float num1;
            float num2;
            float res = 0;

            Console.Write("Enter the first number: ");
            float.TryParse(Console.ReadLine(), out num1);

            Console.Write("Enter the second number: ");
            float.TryParse(Console.ReadLine(), out num2);

            res = num1 + num2;
            res = res + (num1 - num2);
            res = res + (num1 * num2);
            res = res + (num1 / num2);

            return res;
        }

        static void ManipulateArray()
        {
            // Description
            // Write a program that performs the following tasks:
            // - Ask the user to enter 5 numbers, one at a time. Store these numbers in an array.
            // - Find the sum, average, and maximum value of the numbers in the array.
            // - Use a foreach loop to display each number with a message indicating whether it is above or below the average.

            int[] numbers = new int[5];
            int counter = 0;

            do
            {
                Console.Write("Enter a number: ");
                numbers[counter] = int.Parse(Console.ReadLine());
                counter++;
            } while (counter < numbers.Length);

            float sum = numbers.Sum();
            float avg = sum / numbers.Length;
            float max = numbers.Max();

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Avg: {avg}");
            Console.WriteLine($"Max: {max}");

            foreach ( int i in numbers)
            {
                if(i > avg)
                {
                    Console.WriteLine("Above the average");
                } else if(i < avg)
                {
                    Console.WriteLine("Below the average");
                }
            }
        }

        static void GuessTheNumber()
        {
            // Description:
            // Create a simple "Guess the Number" game where:
            // - The program randomly generates a number between 1 and 50.
            // - The user has up to 7 attempts to guess the number.
            // - For each guess, the program indicates whether the guess is too high, too low, or correct.
            // - If the user guesses correctly, the program congratulates them and ends.
            // - If the user fails to guess the number within the 7 attempts, the program reveals the number.

            int answer = new Random().Next(1, 51);
            Console.WriteLine(answer);
            int lives = 6;

            Console.Write("Guess the number, enter a number: ");
            int choice = int.Parse(Console.ReadLine());

            while(answer != choice)
            {
                if (lives > 0)
                {
                    Console.WriteLine($"Lives: {lives}");

                    if (choice > answer) {
                        Console.WriteLine("It's lower try again!");
                    }
                    else
                    {
                        Console.WriteLine("It's higher try again!");
                    }

                    choice = int.Parse(Console.ReadLine());
                    lives--;
                }
                else
                {
                    Console.WriteLine("Game Over!!!!");
                    Console.WriteLine($"The answer is {answer}");
                    break;
                }
            }

            if (choice == answer)
            {
                Console.WriteLine($"You win the answer is {answer}");
            }
        }
    }
}