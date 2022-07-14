Console.Write("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    Console.Write($"Число {firstNumber} больше {secondNumber}");
}else{
    Console.Write($"Число {secondNumber} больше {firstNumber}");
}