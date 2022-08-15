Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
void ToBin(int n)
{
    if (n == 0) return;
    ToBin(n/2);
    Console.Write(n % 2);
}

ToBin(a);