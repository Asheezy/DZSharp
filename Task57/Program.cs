int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

int[] ConvertToArray(int[,] matrix)
{
    int[] convertedArray = new int[matrix.Length];
    int m = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            convertedArray[m] = matrix[i,j];
            m++;
        }        
    }
    return convertedArray;
}

void PrintDiggitCount(int[] array)
{
    int number = array[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i]) count++;
        else
        {
            Console.WriteLine($"Число {number} повторяется {count} раз");
            count = 1;
            number = array[i];
        }
        if (i == array.Length-1)
        {
            Console.WriteLine($"Число {number} повторяется {count} раз");
        }
    }
}

int[,] matrix = GetMatrix(4, 4);
PrintMatrix(matrix);
Console.WriteLine();
int[] convertedArray = ConvertToArray(matrix);
PrintArray(convertedArray);
Console.WriteLine();
Array.Sort(convertedArray);
PrintArray(convertedArray);
Console.WriteLine();
PrintDiggitCount(convertedArray);