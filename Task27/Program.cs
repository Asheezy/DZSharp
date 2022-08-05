Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0)
{
    Console.WriteLine("Число должно быть больше 0");
    return;
}


int SumOfDig(int number)
{
    int dig = 0;
    int summary = 0;
    while (number > 0)
    {
        dig = number % 10;
        summary = summary + dig;
        number = number / 10;
    }
    return summary;
}

int sum = SumOfDig(num);
Console.WriteLine($"{num} -> {sum}");