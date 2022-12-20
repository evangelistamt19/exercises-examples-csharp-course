using System;

namespace RetanguloEx;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Entre com a Largura e Altura do retângulo");
        double larg = double.Parse(Console.ReadLine());
        double alt = double.Parse(Console.ReadLine());

        Retangulo r1 = new Retangulo();
        r1.Altura = alt;
        r1.Largura = larg;

        Console.WriteLine("AREA = " + r1.Area());
        Console.WriteLine("PEÍMETRO = " + r1.Perimetro());
        Console.WriteLine("DIAGONAL = " + r1.Diagonal());

    }
}