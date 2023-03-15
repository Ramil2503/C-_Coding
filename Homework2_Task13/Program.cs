Console.Clear();

Console.Write("Enter number: ");
int n = int.Parse(Console.ReadLine()!);

while (n < 100) {
    Console.Write("There is no 3rd number available!\nEnter correct number: ");
    n = int.Parse(Console.ReadLine()!);
}

while (n > 999) {
    n /= 10;
}

Console.Write($"{n % 10}");
