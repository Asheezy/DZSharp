Console.Write("Задайте первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {number1}, N = {number2} -> ");

void GetNaturalNumbers(int number1, int number2)
{
    if(number1 == number2)
        Console.WriteLine($"{number1}");
    else if (number1 < number2)
        GetNaturalNumbersInc(number1, number2);
    else
        GetNaturalNumbersDec(number2,number1);
}

void GetNaturalNumbersInc(int from, int to)
{
    if (from > to) return;
    Console.Write($"{from} ");
    GetNaturalNumbersInc(++from, to);
}

void GetNaturalNumbersDec(int from, int to)
{
    if (from > to) return;
    Console.Write($"{to} ");
    GetNaturalNumbersDec(from, --to);
}

GetNaturalNumbers(number1, number2);
