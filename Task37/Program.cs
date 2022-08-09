int[] CreateArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

int[] GetSum(int[] array)
{
    if (array.Length % 2 == 0)
    {
        int[] sum = new int[array.Length / 2];
        for (int i = 0; i < array.Length / 2; i++)
        {
            sum[i] = array[i] * array[array.Length - 1 - i];
        }
        return sum;
    }
    else
    {
        int[] sum = new int[array.Length / 2 + 1];
        for (int i = 0; i < array.Length / 2; i++)
        {
            sum[i] = array[i] * array[array.Length - 1 - i];
        }
        sum[sum.Length - 1] = array[array.Length / 2];
        return sum;
    }
}

int[] array = CreateArrayRnd(7, 1, 9);
PrintArray(array);
Console.WriteLine();
int[] summary = GetSum(array);
PrintArray(summary);