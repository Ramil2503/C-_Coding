Console.Clear();
int n = int.Parse(Console.ReadLine()!);
int maxSum = 0, i = 0;

string[] inputArr = Console.ReadLine()!.Split();

int[] arr = new int[n + 2];

for (i = 0; i < n; i++)
{
    arr[i] = int.Parse(inputArr[i]);
}

maxSum = arr[0] + arr[1] + arr[2];

for (i = 0; i < n; i++)
{
    if (arr[i] != 0 && arr[i + 1] != 0 && arr[i + 2] != 0)
    {
        if (arr[i] + arr[i + 1] + arr[i + 2] > maxSum)
            maxSum = arr[i] + arr[i + 1] + arr[i + 2];
    }
}

Console.Write(maxSum);
