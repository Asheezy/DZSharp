int UserInput(string userInput)
{
    Console.WriteLine(userInput);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void Fibbonacci(int number)
{
    int i1 = 0;
    int i2 = 1;
    int i3 = 0;
    Console.Write($"{i1} {i2} ");
   for (int i = 0; i < number-2; i++)
   {
    i3 = i1 + i2;
    Console.Write(i3 + " ");
    i1 = i2;
    i2 = i3;
   }
}

int num = UserInput("Введите число");
Fibbonacci(num);