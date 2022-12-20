namespace ImparPar;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com um numero int");
        int numeroDaEscolha = int.Parse(Console.ReadLine());
        if (numeroDaEscolha % 2 == 0)
        {
            Console.WriteLine("é par");
        }
        else
        {
            Console.WriteLine("é impar");
        }
    }

}