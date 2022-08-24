Console.Write("Задайте число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Console.Write($"{num}");

void GetSumOfDig(int num, int sum)
{
    if (num == 0)
    {
        Console.WriteLine($" -> {sum}");
        return;
    }

    sum = sum + num % 10;
    GetSumOfDig(num / 10, sum);
}

GetSumOfDig(num, sum);