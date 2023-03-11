Console.Clear();

Console.Write("Enter the first number: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Enter the second number: ");
int b = int.Parse(Console.ReadLine()!);

if (a > b)
    Console.Write($"max = {a}, min = {b}");
else
    Console.Write($"max = {b}, min = {a}");