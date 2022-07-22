int num = new Random().Next(100, 1000);
int DeleteSecond(int number)
{
    int firstNumber = number / 100;
    int secondNumber = number % 10;
    int res = firstNumber * 10 + secondNumber;
    return res;
}
int res = DeleteSecond(num);
Console.WriteLine($"{num} --> {res}");