int f(int m, int n)
{
    if (m == n) return n;
    return f(m, n - 1) + n;
}

Console.Clear();
Console.Write("Enter the number for start: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number for end: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(m, n));
