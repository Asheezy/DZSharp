﻿int[] CreateArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int[] GetSumPosNeg(int[] array)
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNeg += array[i];
        }
        else
        {
            sumPos += array[i];
        }
    }
    return new int[] { sumNeg, sumPos };
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

int[] array = CreateArrayRnd(12, -9, 9);
PrintArray(array);
int[] sumPosNeg = GetSumPosNeg(array);
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = {sumPosNeg[1]}");
Console.WriteLine($"Сумма отрицательных чисел = {sumPosNeg[0]}");