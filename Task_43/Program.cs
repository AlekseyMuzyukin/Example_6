Console.WriteLine("Введите первую точку k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вторую точку k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третью точку b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите четвёртую точку b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());


string CommonPoint(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    x = Math.Round(x, 2);
    y = Math.Round(y, 2);
    var result = Convert.ToString($"{x} ; {y}");

    return result;
}

string result = CommonPoint(b1, b2, k1, k2);
Console.WriteLine($"Точка пересечения двух прямых({result})");