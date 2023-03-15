//reading input till user will give zero
//finding second maximum
Console.Clear();

string input = Console.ReadLine();
string[] numbers = null;

if (input != null)
{
    numbers = input?.Split(' ');
}

int max1 = 0, max2 = 0;

if (numbers != null)
{
    foreach (string number in numbers)
    {
        int num = int.Parse(number);

        if (num > max1)
        {
            max2 = max1;
            max1 = num;
        }
        else if (num > max2)
        {
            max2 = num;
        }
    }
}

Console.WriteLine(max2);
