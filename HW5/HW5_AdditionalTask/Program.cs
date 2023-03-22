Console.Clear();
int n = int.Parse(Console.ReadLine()!);
string[] arr = Console.ReadLine()!.Split();
int i = 0, x = 0, y = 0;

for (i = 0; i < n; i++) {
    if (int.Parse(arr[i]) % 2 != 0) {
        Console.Write($"{arr[i]} ");
        x++;
    }
}
Console.WriteLine();
for (i = 0; i < n; i++) {
    if (int.Parse(arr[i]) % 2 == 0) {
        Console.Write($"{arr[i]} ");
        y++;
    }
}

if (x <= y) {
    Console.Write("\nYES");
}
else Console.Write("\nNO");