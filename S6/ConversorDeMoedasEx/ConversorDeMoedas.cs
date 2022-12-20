using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMoedasEx;

internal class ConversorDeMoedas
{
    private static double iof = 6.0; //private pois não tem que ser acessado por outra classe

    public static double Converter(double cotacao ,double valor)
    {
        double livreImposto = valor * cotacao;
        return (livreImposto) + ((iof * livreImposto) / 100);
    }
}
