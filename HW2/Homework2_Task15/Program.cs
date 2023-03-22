Console.Clear();

Console.Write("Enter number: ");
int n = int.Parse(Console.ReadLine()!);

while (n < 1 || n > 7) {
    Console.Write("Enter correct number: ");
    n = int.Parse(Console.ReadLine()!);
}

if (n == 6 || n == 7)
    Console.Write("yes");
else
    Console.Write("no");
