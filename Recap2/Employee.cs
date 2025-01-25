using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap2
{
    /*
    Exercise 3: Employee Tracker (Moderately Difficult)
    Objective: Use advanced class features, static methods/fields, collections, and nullable types.
    */

    class Employee
    {
        private int _nextId = 0;
        private string _department;

        public int Id { get; }
        private string Name { get; }
        public int? Age { get; set; }
        public string? Department { 
            set {
                _department = value;
            }
        }

        public Employee(string name, int? age)
        {
            Id = _nextId++;
            Name = name;
            Age = age;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Employee Information.");
            Console.WriteLine($"   Name: {Name}");
            Console.WriteLine($"   Age: {Age}");
            Console.WriteLine($"   Department: {_department}");
        }
    }
}
