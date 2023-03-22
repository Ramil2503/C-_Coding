Console.Clear();
int[] arr = new int[8];
int cnt = 0, i;
Random rnd = new Random();
for (i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100, 1000);
}
//printing array of numbers
Console.WriteLine("[" + string.Join(", ", arr) + "]");
for (i = 0; i < arr.Length; i += 2) {
    if (arr[i] % 2 == 0)
        cnt++;
}
Console.WriteLine(cnt);
