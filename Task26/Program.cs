Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int GetCountDig(int num)
{
    int inx = 0;
    while (num > 0)
    {
        num = num / 10;
        inx++;
    }
    return inx;
}
int count = GetCountDig(num);
Console.WriteLine($"{num} -> {count}");