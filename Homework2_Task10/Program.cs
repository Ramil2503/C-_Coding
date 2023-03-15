Console.Clear();

Console.Write("Enter number: ");
int n = int.Parse(Console.ReadLine()!);

while (n > 999 || n < 100) {
    Console.Write("The number you entered is not 3 digit number!\nEnter correct number: ");
    n = int.Parse(Console.ReadLine()!);
}

Console.Write($"{n / 10 % 10}");
