﻿Console.Clear();
Console.Write("Enter the number: ");
int n = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= n; i++)
    Console.Write($"{Math.Pow(i, 3)} ");