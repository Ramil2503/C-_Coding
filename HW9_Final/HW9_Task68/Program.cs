int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

Console.Clear();
Console.Write("Enter the value for m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Enter the value for n: ");
int n = int.Parse(Console.ReadLine()!);

int result = Ackermann(m, n);
Console.WriteLine("A({0}, {1}) = {2}", m, n, result);
