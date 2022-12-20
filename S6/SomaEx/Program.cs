namespace SomaEx;

class Program
{
    static void Main(string[] args)
    {
        //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
        // mensagem explicativa, conforme exemplos.
        Console.WriteLine("EX 1");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());


        int result = a + b;
        Console.WriteLine("SOMA = " + result);
    }

}