Console.WriteLine("Введите позиции элемента в двумерном массиве через пробел");
var coordinates = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m + 1, n + 1];
    Random rnd = new Random();
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (j == 1) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],2},");
            else Console.Write($"{array[i, j],2}]");
        }
        Console.WriteLine();
    }
}

void CheckPos(int[,] matrix, int[] coordinates)
{
    if(coordinates[0] < matrix.GetLength(0) && coordinates[1] < matrix.GetLength(1))
    Console.WriteLine($"Строка - {coordinates[0]} столбец - {coordinates[1]} -> {matrix[coordinates[0], coordinates[1]]}");
    else
    Console.WriteLine($"Строка - {coordinates[0]} столбец - {coordinates[1]} -> такого числа в массиве нет");
}

int[,] matrix = GetMatrix(4, 4);
PrintMatrix(matrix);
CheckPos(matrix, coordinates);