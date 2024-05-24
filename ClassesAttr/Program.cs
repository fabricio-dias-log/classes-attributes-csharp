using System.Globalization;

namespace ClassesAttr;

class Program
{
    static void Main(string[] args)
    {
        double xA, xB, xC, yA, yB, yC;

        Console.WriteLine("Entre com as medidas do triângulo X: ");
        xA = double.Parse(s: Console.ReadLine(), CultureInfo.InvariantCulture);
        xB = double.Parse(s: Console.ReadLine(), CultureInfo.InvariantCulture);
        xC = double.Parse(s: Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas do triângulo Y: ");
        yA = double.Parse(s: Console.ReadLine(), CultureInfo.InvariantCulture);
        yB = double.Parse(s: Console.ReadLine(), CultureInfo.InvariantCulture);
        yC = double.Parse(s: Console.ReadLine(), CultureInfo.InvariantCulture);

        double xArea, yArea;
        double xP, yP;

        xP = (xA + xB + xC) / 2;
        xArea = Math.Sqrt(xP * (xP - xA) * (xP - xB) * (xP - xC));
        Console.WriteLine($"Área de X = {xArea.ToString("F4")}");

        yP = (yA + yB + yC) / 2;
        yArea = Math.Sqrt(yP * (yP - yA) * (yP - yB) * (yP - yC));
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