using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoEx;

internal class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    //Teste apenas para ver como refenciar um construtor em outro construtor

    public Produto() { 
        Quantidade= 0;
    }


    //Ou seja aqui criei outro construtor agora com dois parametros
    //porem quero aproveitar o Quantidade = 0; do construtor padrão
    //então eu uso o this() que vai agir: quero que execute tbm esse construtor padrão junto com o de dois paramentros
    // então esse construtor de dois paramentros fica assim:
    //  this.Nome = Nome;
    //  this.Preco = Preco;
    //  Quantidade= 0;
    public Produto(string Nome, double Preco) : this() 
    { 
    
        this.Nome = Nome;
        this.Preco = Preco;
    }


    //Para referenciar um construtor que não seja o padrão, ou seja tem paramentros
    //basta apenas usar o this() com o nome e qtd do construtor que voce quer referenciar ex:
    public Produto(string Nome, double Preco, int Quantidade) : this(Nome, Preco) //this com a mesma qtd e nome do construtor acima
                                                                                  // para poder diferenciar e referenciar o escolhido
    {
        this.Quantidade = Quantidade;
    }




    ///


    public double ValorTotalEmEstoque()
    {
        double total = Quantidade * Preco;
        return total;
    }

    public void AdicionarProdutos(int quantity)
    {
        Quantidade += quantity;
    }

    public void RemoverProdutos(int quantity)
    {
        Quantidade -= quantity;
    }

    //mudando o comportamento do toString
    //public override string ToString()
    //{
    //    return Nome + ", $ " + Preco + ", " + Quantidade + " unidades, Total: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    //}



}
