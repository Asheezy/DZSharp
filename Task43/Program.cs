Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

(double, double) GetXY(double b1, double k1, double b2, double k2)
{
    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    (double, double) tuple = (x, y);
    return tuple;
}

(double, double) tuple = GetXY(b1, k1, b2, k2);
Console.WriteLine($"({tuple.Item1}; {tuple.Item2})");

