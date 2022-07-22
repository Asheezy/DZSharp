Console.WriteLine("Введите два числа");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

int Square(int firstNumber, int secondNumber)
{
    if (firstNumber % secondNumber == 0 || secondNumber % firstNumber == 0) return 0;
    return 1;
}
int res = Square(firstNumber, secondNumber);
if (res == 0) Console.WriteLine($"{firstNumber} {secondNumber} -> да");
else Console.WriteLine($"{firstNumber} {secondNumber} -> нет");
