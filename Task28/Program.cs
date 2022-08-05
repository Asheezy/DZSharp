Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int GetSum(int num)
{
int summary = 1;
    for (int i = 2; i <= num; i++)
    {
        summary = summary * i;
    }
return summary;
}
int sum = GetSum(num);
Console.WriteLine($"{num} -> {sum}");