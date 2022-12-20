
namespace ForeEx;

class Program
{
    static void Main(string[] args)
    {

        //FOR = for (inicio; condição; incremento) { **comandos * *}
        //igual java = usar quando você á sabe a qtd de repetições,
        //ou pelo menos tem como pegar tipo um lenght, ou se envolvem uma contagem e tals

        string nome = "Matheus";
        foreach (char s in nome)
        {
            Console.WriteLine(s);
        }


        //Outro Ex:

        Console.WriteLine("Quantos numeros int você vai digitar ? ");
        int qtdNums = int.Parse(Console.ReadLine());
        int soma = 0;
        for (int nums = 0; nums < qtdNums; nums++)
        {
            Console.WriteLine($"Valor #{nums + 1}: ");
            soma += int.Parse(Console.ReadLine());
        }

        Console.WriteLine(soma);
    }
}

