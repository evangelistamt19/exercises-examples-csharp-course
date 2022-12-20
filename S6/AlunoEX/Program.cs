using System;

namespace AlunoEX;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Digite as três notas do aluno: ");
        double notaA = double.Parse(Console.ReadLine());
        double notaB = double.Parse(Console.ReadLine());
        double notaC = double.Parse(Console.ReadLine());

        Aluno alunoUm = new Aluno();

        alunoUm.NotaA = notaA;
        alunoUm.NotaB = notaB;
        alunoUm.NotaC = notaC;

        double notaFinal = alunoUm.SomarNota();
        Console.WriteLine("NOTA FINAL = " + notaFinal);


        Console.WriteLine(alunoUm.Avaliar(notaFinal));
    }
}