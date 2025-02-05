namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    class Dog: Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
    
    class Cat: Animal
    {
        public void Miau()
        {
            Console.WriteLine("Miauing...");
        }
    }
}

