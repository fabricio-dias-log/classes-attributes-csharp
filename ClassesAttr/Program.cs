﻿using System.Globalization;

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

        double areaX = x.Area();
        double areaY = y.Area();

        Console.WriteLine($"Área de X = {areaX.ToString("F4")}");
        Console.WriteLine($"Área de Y = {areaY.ToString("F4")}");

        if (areaX > areaY)
        {
            Console.WriteLine("Maior área: X");
        } else
        {
            Console.WriteLine("Maior área: Y");
        }
    }
}