Console.WriteLine("Введите два числа");
int a =   Convert.ToInt32(Console.ReadLine());
int b =   Convert.ToInt32(Console.ReadLine());
if (b*b == a)
{
    Console.WriteLine($"Число {a} является квадратом числа {b}");
}else{
    Console.WriteLine($"Число {a} не является квадратом числа {b}");
}
