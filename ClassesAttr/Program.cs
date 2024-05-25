using System.Globalization;

namespace ClassesAttr;

class Program
{
    static void Main(string[] args)
    {
        Triangulo x, y;

        x = new Triangulo();
        y = new Triangulo();

        Console.WriteLine("Entre com as medidas do triângulo X: ");
        x.A = double.Parse(s: Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(s: Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(s: Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas do triângulo Y: ");
        y.A = double.Parse(s: Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(s: Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(s: Console.ReadLine(), CultureInfo.InvariantCulture);

        double xArea, yArea;
        double xP, yP;

        xP = (x.A + x.B + x.C) / 2;
        xArea = Math.Sqrt(xP * (xP - x.A) * (xP - x.B) * (xP - x.C));
        Console.WriteLine($"Área de X = {xArea.ToString("F4")}");

        yP = (y.A + y.B + y.C) / 2;
        yArea = Math.Sqrt(yP * (yP - y.A) * (yP - y.B) * (yP - y.C));
        Console.WriteLine($"Área de X = {yArea.ToString("F4")}");

        if (xArea > yArea)
        {
            Console.WriteLine("Maior área: X");
        } else
        {
            Console.WriteLine("Maior área: Y");
        }
    }
}