using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaE;

internal class Conta
{
    public int NumeroDaConta { get; private set; }
    public string Nome { get; set; }
    public double Saldo { get; private set; }

    public Conta(int numeroDaConta, string nome)
    {
        NumeroDaConta = numeroDaConta;
        Nome = nome;
    }

    public double CalcularSaldo(double depositoIncial)
    {
        Saldo += depositoIncial;
        return Saldo;
    }

    public double Deposito(double valor)
    {
        return Saldo += valor;
    }

    public double Saque(double valor)
    {
        double taxa = 5.0;
        return Saldo = Saldo - (valor + taxa);
    }


}
