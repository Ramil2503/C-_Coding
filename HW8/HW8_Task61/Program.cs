int N = 10; // number of rows to print
int[][] triangle = new int[N][];

for (int i = 0; i < N; i++)
{
    triangle[i] = new int[i + 1];
    for (int j = 0; j <= i; j++)
    {
        if (j == 0 || j == i)
        {
            triangle[i][j] = 1;
        }
        else
        {
            triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
        }
    }
}

// print the triangle
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N - i - 1; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write(triangle[i][j] + " ");
    }
    Console.WriteLine();
}
