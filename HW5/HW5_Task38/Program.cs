void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble() * (100 - (-100)) - 100;
}

double FindDifference(double[] array)
{
    double min = array[0], max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
    }
    return max - min;
}

Console.Clear();
double[] array = new double[5];
InputArray(array);
Console.WriteLine($"Array: [{string.Join(", ", array)}]");
Console.WriteLine($"Difference between max and min: {FindDifference(array):F2}");
