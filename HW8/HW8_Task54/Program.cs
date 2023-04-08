// Задаем двумерный массив
int[,] arr = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int rows = arr.GetLength(0); // количество строк
int cols = arr.GetLength(1); // количество столбцов

// Обходим каждую строку и сортируем ее элементы
for (int i = 0; i < rows; i++)
{
    // Создаем временный массив для хранения отсортированных элементов
    int[] tempArr = new int[cols];
    for (int j = 0; j < cols; j++)
    {
        tempArr[j] = arr[i, j];
    }
    Array.Sort(tempArr);
    Array.Reverse(tempArr);

    // Копируем отсортированные элементы обратно в исходный массив
    for (int j = 0; j < cols; j++)
    {
        arr[i, j] = tempArr[j];
    }
}

// Выводим отсортированный массив на экран
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
