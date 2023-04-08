// Создаем объект генератора случайных чисел
Random rand = new Random();

// Создаем трехмерный массив
int[,,] arr = new int[2, 2, 2];

// Заполняем массив случайными двузначными числами
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            arr[i, j, k] = rand.Next(10, 100); // генерируем случайное двузначное число
        }
    }
}

// Выводим массив построчно с индексами
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            Console.Write(arr[i, j, k] + "(" + i + "," + j + "," + k + ") ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
