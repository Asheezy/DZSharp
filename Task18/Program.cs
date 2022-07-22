Console.WriteLine("Введите номер четверти");
string num = Console.ReadLine();

string Square(string number)
{
    if (num == "1") return "Диапозон (x > 0, y > 0)";
    if (num == "2") return "Диапозон (x < 0, y > 0)";
    if (num == "3") return "Диапозон (x < 0, y < 0)";
    if (num == "4") return "Диапозон (x > 0, y < 0)";
    else return "Неверное значение";
}
string result = Square(num);
Console.WriteLine(result);