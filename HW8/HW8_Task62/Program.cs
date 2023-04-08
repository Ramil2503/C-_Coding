int[,] matrix = new int[4, 4];

int currentNumber = 1;
int currentRow = 0;
int currentCol = 0;
int lastRow = 3;
int lastCol = 3;

while (currentNumber <= 16)
{
    // заполнение верхней горизонтальной строки слева направо
    for (int col = currentCol; col <= lastCol; col++)
    {
        matrix[currentRow, col] = currentNumber;
        currentNumber++;
    }
    currentRow++;

    // заполнение правой вертикальной строки сверху вниз
    for (int row = currentRow; row <= lastRow; row++)
    {
        matrix[row, lastCol] = currentNumber;
        currentNumber++;
    }
    lastCol--;

    // заполнение нижней горизонтальной строки справа налево
    for (int col = lastCol; col >= currentCol; col--)
    {
        matrix[lastRow, col] = currentNumber;
        currentNumber++;
    }
    lastRow--;

    // заполнение левой вертикальной строки снизу вверх
    for (int row = lastRow; row >= currentRow; row--)
    {
        matrix[row, currentCol] = currentNumber;
        currentNumber++;
    }
    currentCol++;
}

// вывод на экран заполненного массива
for (int row = 0; row < 4; row++)
{
    for (int col = 0; col < 4; col++)
    {
        Console.Write("{0:D2} ", matrix[row, col]);
    }
    Console.WriteLine();
}
