void SumOfNumbers(int number1, int number2, int sum)
{
    if (number1 >= number2 + 1)
    {
        Console.WriteLine($"{sum}");
        return;
    }
    sum = sum + number1;
    SumOfNumbers(number1 + 1, number2, sum);
}

Console.Write("Задайте первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = 0;

Console.Write($"N = {num1}, M = {num2} -> ");

SumOfNumbers(num1, num2, sum);