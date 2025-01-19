void FirstMethod()
{
    Console.WriteLine("Hi!");
    Console.WriteLine("First Method");
}

void Greet(string name)
{
    Console.WriteLine($"Hello {name}, nice to meet you.");
}

int Add(int number1, int number2)
{
    return number1 + number2;
}

FirstMethod();
Greet("Gustavoid");
int result = Add(3, 4);

Console.WriteLine(result);

