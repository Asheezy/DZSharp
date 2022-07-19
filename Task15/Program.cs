Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 8 && number > 0) 
{
    if (number == 6 || number == 7) Console.WriteLine("Выходной");
    else Console.WriteLine("Будний день");
}else{
    Console.WriteLine ("Неверное число");
}