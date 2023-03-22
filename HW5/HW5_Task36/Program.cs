Console.Clear();
int[] arr = new int[4];
int sum = 0, i;
Random rnd = new Random();
for (i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-100, 100);
}
//printing array of numbers
Console.WriteLine("[" + string.Join(", ", arr) + "]");
for (i = 1; i < arr.Length; i += 2) {
    sum += arr[i];
}
Console.WriteLine(sum);
