Console.Clear();
int m = 3;
int n = 4;

int[,] matrix = new int[m, n];
double[] ans = new double[4];
int averageOfColumn = 0;
Random rand = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rand.Next(1, 10);
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write("{0,4} ", arr[i, j]);
        }
        Console.WriteLine();
    }
}
PrintArray(matrix);

void ColumnAverage(int[,] arr)
{
    for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
        {
            averageOfColumn += arr[i, j];
        }
        ans[j] = averageOfColumn;
        averageOfColumn = 0;
    }
}
ColumnAverage(matrix);

Console.WriteLine("sum for every column:\n[{0}]", string.Join(", ", ans));

for (int i = 0; i < ans.Length; i++) {
    ans[i] = ans[i] / 3;
}

Console.WriteLine("average for every column:\n[{0}]", string.Join(", ", ans.Select(x => $"{x:F2}")));
