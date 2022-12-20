using System;

namespace ProdutoEx;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre os dados do produto: ");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());
        Console.Write("Quantidade no estoque: ");
        int qtd = int.Parse(Console.ReadLine());

        Produto produto = new Produto();
        produto.Nome = nome;
        produto.Preco = preco;
        produto.Quantidade = qtd;

        //O writeline tem implicitamente o metodo toString, e como o seu comportamento foi alterado na classe Produto, passamos apenas
        // o nome do obejeto que no caso é o produto, e ele vai retornar a string que colocamos na classe Produto
        Console.WriteLine($"Dados do produto: " + produto);

        Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
        int qtdAdd = int.Parse(Console.ReadLine());
        produto.AdicionarProdutos(qtdAdd);

        Console.WriteLine($"Dados atualizados: " + produto);
        Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
        int qtdRem = int.Parse(Console.ReadLine());
        produto.RemoverProdutos(qtdRem);

        Console.WriteLine($"Dados atualizados: " + produto);

        //** QUE FIQUE CLARO SÓ ESTA SENDO POSSÍVEL PASSAR O "Dados atualizados: " + produto  pois alteramos
        //** o comportamento do metodo toString na clase Produto
    }
}