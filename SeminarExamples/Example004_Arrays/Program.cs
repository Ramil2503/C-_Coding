int[,] array = new int[3, 4] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

int numRows = array.GetLength(0);
int numCols = array.GetLength(1);

Console.WriteLine("Initial Array:");
for (int i = 0; i < numRows; i++) {
    for (int j = 0; j < numCols; j++) {
        Console.Write("{0,2} ", array[i, j]);
    }
    Console.WriteLine();
}

for (int j = 0; j < numCols; j++) {
    int temp = array[0, j];
    array[0, j] = array[numRows - 1, j];
    array[numRows - 1, j] = temp;
}

Console.WriteLine("\nFinal Array:");
for (int i = 0; i < numRows; i++) {
    for (int j = 0; j < numCols; j++) {
        Console.Write("{0,2} ", array[i, j]);
    }
    Console.WriteLine();
}
