using System;
using System.Globalization;

namespace RaioEx;

class Raio
{
    //private static double _pi = 3.14; propeties tradicional
    public static double Pi { get; private set; } = 3.14; //aqui diz que o get é permitido mas o set é privado ou seja,
                                                          //outra classe não pode alterar o valor de pi

    //auto-prop só podem ser utilizadas em atributos que não nescessitam de uma logica especifica no get ou set
    //por exemplo um if no set falando que o valor só pode ser alterado caso seja maior que 1
    //para isso é preciso usar o set e get tradicional, criando aqueles "metodos"

    public Raio() {

    }


    //ESSES GET E SET ABAIXO SÃO 100% VALIDAS POREM NAO MUITO USADAS NO C# VISTO QUE EXISTE AS PROPETIERS
    ////para acessar objetos privados em outra classe tem que ser criado os metodos get e set:
    //static public double GetPi() //acessar o pi
    //{
    //    return _pi;
    //}
    ////alterar o pi *****É APENAS UM EX DO SET, OBVIO QUE TU NAO VAI DEIXAR O VALOR DE PI SER ALTERADO NÉ IRMAO****
    //static public void SetPi(double alt)
    //{
    //    _pi = alt;
    //}


    //PROPETIES
    //public static double Pi
    //{
    //    get { return _pi; } //acessar o pi
     //   set { _pi = value; } //alterar o valor, nesse caso tem que passar o value,
                             //pois não tem como definir o paramentro como um paramentro normal
    // }

    //porem supondo pi fosse public o usuario não pode alterar porem nao tem problema ele acessar e apenas ver
    //então podemos usar a auto-propeties que são definidas lá nos atrubutos

    public static double Circuferencia(double raio)
    {
        return 2 * (Pi * raio);
    }

    public static double Volume(double raio)
    {
        return (4 * (Pi * (Math.Pow(raio, 3)))) / 3;
    }


}
