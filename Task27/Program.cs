Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

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