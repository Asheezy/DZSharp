int num = new Random().Next(10, 100);
int firstDigit = num / 10;
int secondDigit = num % 10;
if (firstDigit == secondDigit) Console.WriteLine("Цифры одинаковые");
else if (firstDigit > secondDigit) Console.WriteLine($"{num} -> {firstDigit}");
else Console.WriteLine($"{num} -> {secondDigit}");