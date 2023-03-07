Console.Clear();

Console.Write("Enter the number: ");
int n = int.Parse(Console.ReadLine()!);

while (n < 1 || n > 7) {
    Console.Write("The number you entered is not valid, enter number between 1 and 7: ");
    n = int.Parse(Console.ReadLine()!);
}

if (n == 1)
    Console.Write("Monday");
else if(n == 2)
    Console.Write("Tuesday");
else if(n == 3)
    Console.Write("Wendesday");
else if(n == 4)
    Console.Write("Thursday");
else if(n == 5)
    Console.Write("Friday");
else if(n == 6)
    Console.Write("Saturday");
else
    Console.Write("Sunday");