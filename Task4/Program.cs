Console.Write("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (firstNumber > secondNumber)
{
    max = firstNumber;
}

if (firstNumber < secondNumber)
{
    max = secondNumber;
}
if (max > thirdNumber)
{
    Console.Write($"Наибольшее число из трех {firstNumber} {secondNumber} {thirdNumber} это {max}");
}
else {
     Console.Write($"Наибольшее число из трех {firstNumber} {secondNumber} {thirdNumber} это {thirdNumber}");
}