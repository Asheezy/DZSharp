Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 0)
{
    Console.WriteLine("Число меньше или равно 0");
    return;
}
int ReverseNumber(int number)
{
    int diggit = 0;
    int reverse = 0;
    while (number > 0)
    {
        diggit = number % 10;
        reverse = reverse * 10 + diggit;
        number = number / 10;
    }
    return reverse;
}
int result = ReverseNumber(n);
if (result == n) Console.WriteLine($"{n} -> да");
else Console.WriteLine($"{n} -> нет");
