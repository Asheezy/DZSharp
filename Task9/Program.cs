int num = new Random().Next(10, 100);

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit == secondDigit) return 0;
    else if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}

int maxDigit = MaxDigit(num);
if (maxDigit == 0) Console.WriteLine($"{num} -> Цифры одинаковые");
else Console.WriteLine($"{num} -> {maxDigit}");