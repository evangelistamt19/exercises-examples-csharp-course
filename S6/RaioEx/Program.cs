using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RaioEx;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("Entre com o valor do raio: ");
        //double raio = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));


        //Raio r1 = new Raio();
        ////r1.Draio = raio; caso raio não fosse static 
        //Raio.Draio = raio;



        //Console.WriteLine("Circunferência : " + r1.Circuferencia().ToString("F2", CultureInfo.InvariantCulture));

        //Console.WriteLine("Valume : " + r1.Volume().ToString("F2", CultureInfo.InvariantCulture));

        //Console.WriteLine("Valor de PI: " + Raio.Pi.ToString("F2", CultureInfo.InvariantCulture));




        //////MESMO EX ACIMA SÓ QUE COM MEMROS STATIC
        //Console.Write("Entre com o valor do raio: ");
        //double raio = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

        //Console.WriteLine("Circunferência : " + Raio.Circuferencia(raio).ToString("F2", CultureInfo.InvariantCulture));


        //Console.WriteLine("Volume : " + Raio.Volume(raio).ToString("F2", CultureInfo.InvariantCulture));

        //Console.WriteLine("Valor de PI: " + Math.PI.ToString("F2", CultureInfo.InvariantCulture));



        ////Obtendo e recebendo o Pi com as propetie
        ////alterando o valor de Pi agr pelo set Pi e não pelo atributo privado _pi
        ////Raio.Pi = 666; //porem não funciona, pois na classe definos que get esta liberado porem o set esta privado ja que esse
        //               //valor não pode ser alterado
        ////mostrando o valor de pi agr pelo set Pi e não pelo atributo privado _pi
        //Console.WriteLine("Valor de PI: " + Raio.Pi.ToString("F2", CultureInfo.InvariantCulture));





        //mostrando pi
        //Console.WriteLine("Valor de PI: " + Raio.GetPi().ToString("F2", CultureInfo.InvariantCulture));
        //alterar o pi na classe raio*****
        //****É APENAS UM EX DO SET, OBVIO QUE TU NAO VAI DEIXAR O VALOR DE PI SER ALTERADO NÉ IRMAO****
        //Raio.SetPi(666);
        //Console.WriteLine("Valor de PI: " + Raio.GetPi().ToString("F2", CultureInfo.InvariantCulture));
    }
}