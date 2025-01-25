using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap2
{
    /*
    Exercise 2: Library System (Medium)
    Objective: Work with classes, objects, methods, properties, loops, and collections.
    */

    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsAvailable = true; // Default value
        }
        
        public void DisplayDetails()
        {
            string isAvailable = IsAvailable ? "Yes" : "No";

            Console.WriteLine("=== Book Information ===");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Is available: {isAvailable}");
        }
    }
}
