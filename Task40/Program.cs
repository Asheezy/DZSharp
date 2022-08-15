int first = GetUserInput();
int second = GetUserInput();
int third = GetUserInput();

if(IsTriangle(first,second,third))
Console.WriteLine($"Треугольник со сторонами {first}, {second}, {third} может существовать");
else 
Console.WriteLine($"Треугольник со сторонами {first}, {second}, {third} не может существовать");
int GetUserInput()
{
    Console.WriteLine("Введите число ");
    return Convert.ToInt32(Console.ReadLine());
}

bool IsTriangle(int first, int second, int third)
{
    if (first < second + third && second < first + third && third < first + second) return true;
    else return false;
}