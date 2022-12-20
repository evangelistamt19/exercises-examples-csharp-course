﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetanguloEx;

internal class Retangulo
{
    public double Largura;
    public double Altura;



    public double Area()
    {
        return Largura * Altura;
    }



    public double Perimetro()
    {
        return (Largura + Altura) * 2;
    }


    public double Diagonal()
    {
        double d = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        return d;
    }
}
