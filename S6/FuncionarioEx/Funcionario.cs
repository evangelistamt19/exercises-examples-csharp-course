﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioEx;

internal class Funcionario
{
    public string Nome;
    public double SalarioBruto;
    public double Imposto;



    public double SalarioLiquido()
    {   

        double salarioTeste = SalarioBruto - Imposto;
        return salarioTeste;

    }

    public void AumentarSalario(double porcentagem)
    {
        SalarioBruto += SalarioBruto * (porcentagem / 100) - Imposto;
    }
}