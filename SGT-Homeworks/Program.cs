// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Homework Day 8 - Dora L.
//double T = 6;
//double R = 8;

double result1;
Console.WriteLine("Insert first value:");
double T = double.Parse(Console.ReadLine());
Console.WriteLine("Insert second value:");
double R = double.Parse(Console.ReadLine());

Console.WriteLine("\nChoose an action to do with the variables:");
Console.WriteLine("+ to sum both elements");
Console.WriteLine("- to do subtraction;");
Console.WriteLine("/ to do dividing;");
Console.WriteLine("* to do multiplication;");
Console.WriteLine("% to get remainder when the first element is divided by the second element;");
Console.WriteLine("p to print out both elements;");
Console.WriteLine("b to verify which element is bigger;");
Console.WriteLine("s to verify which element is smaller;\n");

char action = char.ToLower(char.Parse(Console.ReadLine()));
switch (action)
{
    case '+':
        result1 = (T+R);
        Console.WriteLine($"\nThe result is {result1}.");
        break;
    case '-':
        result1 = (T-R);
        Console.WriteLine($"\nThe result is {result1}.");
        break;
    case '/':
        result1 = (T/R);
        Console.WriteLine($"\nThe result is {result1}.");
        break;
    case '*':
        result1 = (T*R);
        Console.WriteLine($"\nThe result is {result1}.");
        break;
    case '%':
        result1 = (T%R);
        Console.WriteLine($"\nThe result is {result1}.");
        break;
    case 'p':
        Console.WriteLine($"\nThe values are {T} and {R}.");
        break;
    case 'b':
        Console.WriteLine($"\nThe greater value is {Math.Max(R, T)}.");
        break;
    case 's':
        Console.WriteLine($"\nThe smaller value is {Math.Min(R, T)}.");
        break;
    default:
        Console.WriteLine("\nInvalid action!");
        break;
}