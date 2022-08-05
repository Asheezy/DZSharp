Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int GetSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int result = GetSum(num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {result}");