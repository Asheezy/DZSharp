Console.Clear();
int[] arr = new int[8];

int[] GetRandom(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

void WriteArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if(i != arr.Length -1)
        Console.Write(",");
    }
        Console.Write("]");
}

arr = GetRandom(arr);
WriteArr(arr);