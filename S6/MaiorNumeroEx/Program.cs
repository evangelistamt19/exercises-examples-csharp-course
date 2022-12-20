namespace MaiorNumeroEx;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite 3 numeros");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        string maiorNumero()
        {
            int maior = Math.Max(num1, Math.Max(num2, num3));
            return "O maior número é: " + maior;
        }

        Console.WriteLine(maiorNumero());
    }

}