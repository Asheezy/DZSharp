int[] array = RandomArray(8);
WriteArr(array);

int[] RandomArray(int arrLen)
{
    Random rnd = new Random();
    int[] arr = new int[arrLen];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}

void WriteArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i != arr.Length - 1)
            Console.Write(",");
    }
    Console.Write("]");
}