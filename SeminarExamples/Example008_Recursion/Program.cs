int f(int n)
{
    if (n < 10) {
        return n;
    }
    return f(n / 10) + n % 10;
}

Console.Clear();
Console.Write("Enter the number: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(n));
/*
f(5) -> f(4) + "5 "
          |
          f(3) + "4 "
            |
            f(2) + "3 "
              |
              f(1) + "2 "
                |
                "1 "
*/
