Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)                       // В условиях задачи написано про трехзначное число
{
        Console.WriteLine(number / 10 % 10);
}else{
     Console.WriteLine("Число не трехзначное");          // Считаются ли эти строчки перевыполнением?
}
