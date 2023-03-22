Console.Clear();
string[] numbers = Console.ReadLine()!.Split();

int A = int.Parse(numbers[0]);
int B = int.Parse(numbers[1]);

int result = 1;
for (int i = 0; i < B; i++)
{
    result *= A;
}
Console.WriteLine(result);
