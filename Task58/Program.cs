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

void MultiplyMatrix(int[,] matrixOne, int[,] matrixTwo, int[,] matrixResult)
{
  for (int i = 0; i < matrixResult.GetLength(0); i++)
  {
    for (int j = 0; j < matrixResult.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrixResult.GetLength(1); k++)
      {
        sum += matrixOne[i,k] * matrixTwo[k,j];
      }
      matrixResult[i,j] = sum;
    }
  }
}

int[,] matrixOne = GetMatrix(2, 2);
int[,] matrixTwo = GetMatrix(2, 2);
int[,] matrixResult = new int[matrixOne.GetLength(0),matrixTwo.GetLength(1)];
PrintMatrix(matrixOne);
Console.WriteLine();
PrintMatrix(matrixTwo);
MultiplyMatrix(matrixOne, matrixTwo, matrixResult);
Console.WriteLine();
PrintMatrix(matrixResult);