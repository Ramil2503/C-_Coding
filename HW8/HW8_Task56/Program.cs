// Задаем двумерный массив
int[,] arr = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
int rows = arr.GetLength(0); // количество строк
int cols = arr.GetLength(1); // количество столбцов

int minRow = 0; // индекс строки с наименьшей суммой элементов
int minSum = int.MaxValue; // начальное значение для наименьшей суммы

// Обходим каждую строку и считаем сумму элементов
for (int i = 0; i < rows; i++)
{
    int sum = 0;
    for (int j = 0; j < cols; j++)
    {
        sum += arr[i, j];
    }

    // Если текущая сумма меньше минимальной, обновляем значения
    if (sum < minSum)
    {
        minSum = sum;
        minRow = i;
    }
}

// Выводим результат на экран
Console.WriteLine("The line with the minimal sum: " + (minRow + 1));
