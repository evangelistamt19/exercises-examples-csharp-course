using ContaE;
using System;
using System.Globalization;

namespace ExsEstruturaSequencial;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entre com o número da conta: ");
        int numeroConta = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");
        string nomeTitular = (Console.ReadLine());

        double depositoInicial = 0.0;

        Conta c1 = new Conta(numeroConta, nomeTitular);


        Console.Write("Haverá deposito inicial ? (s/n) ");
        char depositoInicialEscolha = char.Parse(Console.ReadLine());
        if (depositoInicialEscolha.Equals('s'))
        {
            Console.Write("Entre o valor de depósito incial: ");
            depositoInicial = double.Parse(Console.ReadLine());
            c1.CalcularSaldo(depositoInicial);
        }

        Console.WriteLine("Dados da conta:");
        Console.WriteLine("Conta " + c1.NumeroDaConta + ", Titular: " + c1.Nome + ", Saldo: " + c1.Saldo);


        Console.Write("Entre com um valor para depósito: ");
        double valorDeposito = double.Parse(Console.ReadLine());
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine("Conta " + c1.NumeroDaConta + ", Titular: " + c1.Nome + ", Saldo: " + c1.Deposito(valorDeposito));


        Console.Write("Entre com um valor para saque: ");
        double valorSaque = double.Parse(Console.ReadLine());
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine("Conta " + c1.NumeroDaConta + ", Titular: " + c1.Nome + ", Saldo: " + c1.Saque(valorSaque));

    }

}