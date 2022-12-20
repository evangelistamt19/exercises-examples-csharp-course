namespace WhileEx;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Digite um numero: ");
        int numero = int.Parse(Console.ReadLine());
        double raiz = 0;

        while (numero >= 0)
        {
            raiz = Math.Sqrt(numero);
            Console.WriteLine(raiz.ToString("F3"));
            numero = int.Parse(Console.ReadLine());

        }

    }
}