Console.Write("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (firstNumber > max) max = firstNumber;
if (firstNumber > max) max = secondNumber;
if (thirdNumber > max) max = thirdNumber;

Console.WriteLine($"Максимальное значение = {max}");