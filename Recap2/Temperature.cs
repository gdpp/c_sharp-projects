using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap2
{
    /*
    Exercise 1: Temperature Converter (Easy)
    Objective: Practice variables, data types, console input/output, arithmetic operators, and if statements.
    */

    class Temperature
    {
        public float Value { get; set; }
        public char Unit { get; set; }
        public float Farenheit { get; set; }
        public float Celsius { get; set; }
        
        public Temperature(float temperature, char unit) 
        {
            Value = temperature;
            Unit = unit;
        }

        public void ConvertToFarenheit()
        {
            Farenheit = Value * 9 / 5 + 32;
        }

        public void ConvertToCelsius()
        {
            Celsius = (Value - 32 ) * 5 / 9;
        }

        public void DisplayResult() 
        {
            if (Unit == 'C')
            {
                Console.WriteLine($"The temperature in Farenheit is: {Farenheit}°F");
            }
            else 
            {
                Console.WriteLine($"The temperature in Celcius is: {Celsius}°C");
            }
        }
    }
}
