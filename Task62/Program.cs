void SortSpiral(int[,] matrix)
{
    int pos = 1;
    int row = 0;
    int column = 0;

    while (pos <= matrix.Length)
    {
        matrix[row, column] = pos;
        pos++;
        if (row <= column + 1 && row + column < matrix.GetLength(1) - 1)
            column++;
        else if (row < column && row + column >= matrix.GetLength(0) - 1)
            row++;
        else if (row >= column && row + column > matrix.GetLength(1) - 1)
            column--;
        else
            row--;
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] / 10 <= 0)
                Console.Write($"0{matrix[i, j]} ");

            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[4, 4];
SortSpiral(matrix);
PrintMatrix(matrix);