int[] InputArray()
{
    Console.Clear();
    int n = int.Parse(Console.ReadLine()!), i = 0;
    string[] inputArr = Console.ReadLine()!.Split();
    int[] arr = new int[n];
    for (i = 0; i < n; i++)
    {
        arr[i] = int.Parse(inputArr[i]);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}


int[] array;
array = InputArray();
PrintArray(array);
Console.WriteLine($"The number of elements bigger than 0 --- {CountPositiveNumbers(array)}");