using System;

namespace FuncionarioEx;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Salário Bruto: ");
        double salarioBruto = double.Parse(Console.ReadLine());

        Console.Write("Imposto: ");
        double imposto = double.Parse(Console.ReadLine());


        Funcionario f1 = new Funcionario();
        f1.Nome = nome;
        f1.SalarioBruto = salarioBruto;
        f1.Imposto = imposto;


        Console.WriteLine("Funcionário: $ " + f1.Nome + ", " + f1.SalarioLiquido());

        //Aumentar o salario
        Console.Write("Digite a porcentagem para aumentar o salário: ");
        double porcentagem = double.Parse(Console.ReadLine());
        f1.AumentarSalario(porcentagem);

        Console.WriteLine("Dados atualizados: " + f1.Nome + ", $ " + f1.SalarioBruto);
    }
}