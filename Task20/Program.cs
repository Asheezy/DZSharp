Console.WriteLine("Введите координаты первой точки ");
Console.Write("x ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("y ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки ");
Console.Write("x ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("y ");
int yb = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int x2, int y1, int y2)
{
    return  Math.Round(Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1))), 2, MidpointRounding.ToZero);
}

Console.WriteLine(Distance(xb, xa, yb, ya));