int AckermannFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckermannFunction(m - 1, 1);
  else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.Write("Задайте первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write($"m = {num1}, n = {num2} -> {AckermannFunction(num1, num2)}");