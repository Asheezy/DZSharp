Console.WriteLine("Введите два числа");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int GetExp(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}
int res = GetExp(numA, numB);
Console.WriteLine($"{numA},{numB} -> {res}");