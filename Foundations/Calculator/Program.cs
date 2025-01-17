using System.Globalization;
using System.Runtime.CompilerServices;

Console.WriteLine("*** Calculator ***");

//double pi = 3.11415;
//string name = "Gustavo";
//int power = 3000;
//bool isAlive = true;
//float ratio = 1.2f;

Console.Write("Enter number 1: ");
float num1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Enter number 2: ");
float num2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// Console.WriteLine("Result is... " + (num1 + num2));

// string interpolation
Console.WriteLine($"Result is... {Math.Round(num1 + num2, 2)}");
Console.WriteLine($"Result is... {Math.Round(num1 - num2, 2)}");
Console.WriteLine($"Result is... {Math.Round(num1 * num2, 2)}");
Console.WriteLine($"Result is... {Math.Round(num1 / num2, 2)}");

char favCharacter = 'a';

Console.WriteLine(favCharacter);

Console.WriteLine("Hello {0}, nice to meet {1}", "Gus", "you.");

string str1 = "this is a \"string\" with \na backslash \\ and a colon :";

Console.WriteLine(str1);

bool isRainy = false;
bool hasUmbrella = true;

if (isRainy)
{
    Console.WriteLine("It's rainy");
}

Console.WriteLine("It's OK");

// Logical Operators

// AND &&
// OR ||
// NOT !

if(isRainy && hasUmbrella)
{
    Console.WriteLine("Great, you're safe of the rain");
}

// Critical attack?
Console.Write("Enter yout attack amount: ");
int atkAmount = int.Parse(Console.ReadLine());

bool isCriticalHit = false;

if (atkAmount > 300)
{
    isCriticalHit = true;
}

Console.WriteLine("Power attack of: {0}", atkAmount);

if (isCriticalHit)
{
    Console.WriteLine("Critical Hit!!!!");
}

bool  isDeath = atkAmount > 700 ? true : false;

if (isDeath)
{
    Console.WriteLine("You win");
}

Console.WriteLine("Enter an option (1, 2 or 3)");
int opc = int.Parse(Console.ReadLine());

// SWITCH
switch (opc)
{
    case 1:
        Console.WriteLine("1");
        break;
    case 2:
        Console.WriteLine("2");
        break;
    case 3:
        Console.WriteLine("3");
        break;
    default:
        Console.WriteLine("Invalid Opc");
        break;

}

int points = 0;

string q1 = "What is the capital of Peru?";
string a1 = "lima";

string q2 = "What is 2 x 2?";
string a2 = "4";

string q3 = "What color do you get by mixing blue and yellow?";
string a3 = "green";

Console.WriteLine(q1);
string userAnswer = Console.ReadLine();

if(userAnswer.Trim().ToLower() == a1)
{
    Console.WriteLine("Correct you get 1 point");
    points++;
} 
else
{
    Console.WriteLine("Incorrect!!");
    Console.WriteLine("The correct answer is:");
    Console.WriteLine(a1);
}

Console.WriteLine(q2);
userAnswer = Console.ReadLine();

if (userAnswer.Trim().ToLower() == a2)
{
    Console.WriteLine("Correct you get 1 point");
    points++;
}
else
{
    Console.WriteLine("Incorrect!!");
    Console.WriteLine("The correct answer is:");
    Console.WriteLine(a2);
}

Console.WriteLine(q3);
userAnswer = Console.ReadLine();

if (userAnswer.Trim().ToLower() == a3)
{
    Console.WriteLine("Correct you get 1 point");
    points++;
}
else
{
    Console.WriteLine("Incorrect!!");
    Console.WriteLine("The correct answer is:");
    Console.WriteLine(a3);
}

Console.WriteLine($"Quiz complete.\nYou've obtained {points}/3 points");

Console.WriteLine("Enter a NUMBER:");
string inputString = Console.ReadLine();

int num;

int.TryParse(inputString, out num);

Console.Write("User number +1: " + num);

Random random = new Random();

int randomNumber = random.Next(1, 11);
Console.Write("Enter a number: ");
