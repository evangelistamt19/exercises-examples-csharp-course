using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloEX;

class Triangulo
{
    double ladoUm;
    double ladoDois;
    double ladoTres;


    public Triangulo(double ladoUm, double ladoDois, double ladoTres)
    {
        this.ladoUm = ladoUm;
        this.ladoDois = ladoDois;
        this.ladoTres = ladoTres;
    }

    public double CalcArea()
    {
        double p = (ladoUm + ladoDois + ladoTres) / 2;
        double area = Math.Sqrt(p * (p - ladoUm) * (p - ladoDois) * (p - ladoTres));
        return area;
    }
}
