int[,,] Get3DMatrix(int m, int n, int z)
{
    int[,,] matrix = new int[m, n, z];
    int[] checkArr = new int[matrix.Length];
    Random rnd = new Random();
    int number;
    for (int i = 0; i < checkArr.Length; i++)
    {
        checkArr[i] = rnd.Next(10, 100);
        number = checkArr[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (checkArr[i] == checkArr[j])
                {
                    checkArr[i] = rnd.Next(10, 100);
                    j = 0;
                    number = checkArr[i];
                }
                number = checkArr[i];
            }
        }
    }
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = checkArr[count];
                count++;
            }
        }
    }
    return matrix;
}


void Print3DMatrix(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"{matrix3D[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] matrix3D = Get3DMatrix(2, 2, 2);
Print3DMatrix(matrix3D);