Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0) Console.WriteLine("Значение меньше или равно 0");

void FindSquare(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"| {i} | {i * i,3} |");
    }
}

FindSquare(num);