
void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);
}

Console.Write("Задайте число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"N = {number} -> ");
NaturalNumbers(number);
