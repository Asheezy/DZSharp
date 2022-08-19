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
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],2},");
            else Console.Write($"{array[i, j],2}]");
        }
        Console.WriteLine();
    }
}

void PrintArithmeticMean(int[,] matrix)
{
    Console.WriteLine($"Cреднее арифметическое каждого столбца: ");
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double arithmeticMean = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            arithmeticMean += matrix[j, i];
        }
        arithmeticMean = Math.Round(arithmeticMean / matrix.GetLength(0), 1);
        Console.WriteLine($"№ {i + 1} - {arithmeticMean}");
    }
}

int[,] matrix = GetMatrix(3, 4);
PrintMatrix(matrix);
Console.WriteLine();
PrintArithmeticMean(matrix);
