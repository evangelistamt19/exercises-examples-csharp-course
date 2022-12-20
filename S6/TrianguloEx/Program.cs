using System;
using System.Globalization;

namespace TrianguloEX;

class Program
{
    static void Main(string[] args)
    {
        Triangulo t1 = new Triangulo(3.00, 4.00, 5.00);
        Triangulo t2 = new Triangulo(7.50, 4.50, 4.02);

        Console.WriteLine(t1.CalcArea().ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine(t2.CalcArea().ToString("F4", CultureInfo.InvariantCulture));

        Console.WriteLine("A área maior é: " + Math.Max(t1.CalcArea(), t2.CalcArea()).ToString("F4", CultureInfo.InvariantCulture));
    }
}