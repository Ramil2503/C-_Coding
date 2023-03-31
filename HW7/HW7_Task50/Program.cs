Console.Clear();
int m = 5;
int n = 7;

int[,] matrix = new int[m, n];
Random rand = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rand.Next(1, 50);
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write("{0,6} ", matrix[i, j]);
        }
        Console.WriteLine();
    }
}
PrintArray(matrix);

Console.Write("Enter the number of row: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number of collumn: ");
int column = int.Parse(Console.ReadLine()!);

if (row < matrix.GetLength(0) && column < matrix.GetLength(1))
{
    int value = matrix[row - 1, column - 1];
    Console.WriteLine($"The value of the element: {value}");
}
else
{
    Console.WriteLine("There is no such position!");
}
