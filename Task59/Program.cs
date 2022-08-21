int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 20);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3}]");
        }
        Console.WriteLine();
    }
}

(int, int) FindMin(int[,] matrix)
{
    int min = matrix[0, 0];
    int m = 0;
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                m = i;
                n = j;
            }
        }
    }
    (int, int) coordinates = (m, n);
    return coordinates;
}

int[,] DeleteMinAndCreateNewMatrix(int[,] matrix, (int, int) coordinates)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        if (m == coordinates.Item1) m++;
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (n == coordinates.Item2) n++;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        n = 0;
        m++;
    }
    return newMatrix;
}

int[,] matrix = GetMatrix(4, 4);
PrintMatrix(matrix);
(int, int) coordinates = FindMin(matrix);
Console.WriteLine();
int[,] newMatrix = DeleteMinAndCreateNewMatrix(matrix, coordinates);
PrintMatrix(newMatrix);