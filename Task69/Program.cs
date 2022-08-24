Console.Write("Задайте первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 > 0)
{
    int Exponent(int num1, int num2)
    {
        if (num2 == 0)
            return 1;
        return Exponent(num1, num2 - 1) * num1;
    }
    if (num2 >= 0)
    {
        int result = Exponent(num1, num2);
        Console.WriteLine(result);
    }
    Exponent(num1, num2);
}
else Console.WriteLine("Ошибка ввода");