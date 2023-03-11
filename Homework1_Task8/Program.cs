Console.Clear();

Console.Write("Enter the number: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = 2; i <= n; i += 2) {
    Console.Write(i);
    if (i + 2 <= n)
        Console.Write(", ");
}
