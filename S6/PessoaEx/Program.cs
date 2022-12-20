using System;

namespace PessoaEx;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dados da primeira pessoa: ");
        Console.Write("Nome: "); string nome = Console.ReadLine();
        Console.Write("Idade: "); int idade = int.Parse(Console.ReadLine());
        Pessoa p1 = new Pessoa(nome, idade);
        Console.WriteLine("Dados da segunda pessoa: ");
        Console.Write("Nome: "); nome = Console.ReadLine();
        Console.Write("Idade: "); idade = int.Parse(Console.ReadLine());
        Pessoa p2 = new Pessoa(nome, idade);



        if (p1.Idade > p2.Idade)
        {
            Console.WriteLine("Pessoa mais velha " + p1.Nome);
        }
        else
        {
            Console.WriteLine("Pessoa mais velha " + p2.Nome);

        }
    }

}

