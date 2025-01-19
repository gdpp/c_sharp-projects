// FOR LOOP

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("I is: " + i);
}

string myStr = "Hi \nHi";

for (int counter = 0; counter <= 5 ; counter++)
{
    Console.WriteLine("Counter is: " + counter);
    Console.WriteLine(myStr);
    Thread.Sleep(1000);
}

// WHILE LOOP

bool condition = true;

while (condition)
{
    Console.WriteLine("While running ");

    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine(i);
        condition = false;
    }
}

Console.WriteLine("End while");


// DO WHILE

bool isAlive = true;
do
{

    Console.WriteLine("Continue? (yes/no)");
    string res = Console.ReadLine();

    if (res.Trim().ToLower() != "yes") { 
        isAlive = false;
    }
}
while (isAlive);



// ARRAYS

int[] numbers = new int[3];

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;

bool[] states = [true, false];

// FOREACH LOOP

foreach (var item in numbers)
{
    Console.WriteLine($"Item: {item}");
}

Console.ReadKey();



