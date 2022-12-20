using System;
using System.Globalization;

namespace ConversorDeMoedasEx;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é a cotação do dolar ? ");
        double cotacao = double.Parse(Console.ReadLine());

        Console.Write("Quntos dólares você vai comprar? ");
        double valor = double.Parse(Console.ReadLine());


        Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoedas.Converter(cotacao, valor)
            .ToString("F2", CultureInfo.InvariantCulture));
    }


}