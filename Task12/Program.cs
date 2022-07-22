Console.WriteLine("Введите первое число, большее");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число, меньшее");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int Method(int firstNumber, int secondNumber)
{
    if (firstNumber % secondNumber == 0) return 0;
    int res = firstNumber % secondNumber;
    return res;
}
int res = Method(firstNumber, secondNumber);
if (res == 0) Console.WriteLine($"{firstNumber} {secondNumber} -> кратно");
else Console.WriteLine($"{firstNumber} {secondNumber} -> не кратно, остаток {res}");