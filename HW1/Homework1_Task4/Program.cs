﻿Console.Clear();

Console.Write("Enter the first number: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Enter the second number: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Enter the third number: ");
int c = int.Parse(Console.ReadLine()!);

int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write($"max = {max}");
