int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}

int MainDiagonal(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum += matrix[i, j];
        }
    }
    return sum;
}

int DiagonalOpt(int[,] matrix)
{
    int sum = 0;
    int length = 0;
    if (matrix.GetLength(0) >= matrix.GetLength(1))
        length = matrix.GetLength(1);
    else
        length = matrix.GetLength(0);
    for (int i = 0; i < length; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

int[,] matrix = GetMatrix(4, 4);
PrintMatrix(matrix);
Console.WriteLine();
int sum1 = DiagonalOpt(matrix);
int sum2 = MainDiagonal(matrix);
Console.WriteLine($"-> {sum1}");
Console.WriteLine($"Оптимизированный вариант -> {sum2}");