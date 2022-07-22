Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int Square(int number)
{
    if(number % 7 == 0 && number % 23 == 0) return 1;
    return 0;
}
int res = Square(number);
if(res == 1) Console.WriteLine($"{number} -> да");
else Console.WriteLine($"{number} -> нет");