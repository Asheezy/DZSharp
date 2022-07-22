Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (99 < number && number < 1000)
{
int lastDigit = number % 10;
Console.WriteLine($"Последняя цифра числа {number} это {lastDigit}");
}else{
Console.WriteLine("Вы ввели неправильное число");
}