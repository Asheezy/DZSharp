double[] CreateArrayRnd(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * 100, 1);
    }
    return arr;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + " ");
        else Console.Write(array[i] + "]");
    }
}

double GetSumMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        else if (min > array[i]) min = array[i];
    }
    double sum = max - min;
    return sum;
}

double[] array = CreateArrayRnd(4, 0, 10);
PrintArray(array);
double sum = Math.Round(GetSumMinMax(array), 1);
Console.WriteLine($" -> {sum}");
