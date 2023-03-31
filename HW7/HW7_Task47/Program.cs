Console.Clear();
int m = 3;
int n = 4;

double[,] matrix = new double[m, n];
Random rand = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rand.NextDouble() * 20 - 10;
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("{0,6:F1} ", matrix[i, j]);
    }
    Console.WriteLine();
}
