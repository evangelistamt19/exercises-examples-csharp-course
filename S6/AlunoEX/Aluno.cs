using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoEX;

internal class Aluno
{
    public string Nome;
    public double NotaA;
    public double NotaB;
    public double NotaC;


    public double SomarNota()
    {
        double notaTotal = NotaA + NotaB + NotaC;   
        return notaTotal;
    }


    public string Avaliar(double notaFinal)
    {
        string respostaPositiva = "APROVADO";
        string respostaNegativa = "REPROVADO \n" +
            "FALTARAM " + (60 - notaFinal) + " PONTOS";
        if (notaFinal >= 60.0)
        {
            return respostaPositiva;
        } else
        {
            return respostaNegativa;
        }

    }

}
