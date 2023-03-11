Console.Clear();

Console.Write("Enter the number: ");
int n = int.Parse(Console.ReadLine()!);

if (n % 2 == 0)
    Console.Write("The number is even!");
else
    Console.Write("The number is odd!");
