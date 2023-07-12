using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cliente_produto
{
    internal class Produto 
    {
        public int Idproduto { get; set; }
        public int Itens { get; set;}
        public double Preco { get; set; }
        public string Descricao { get; set;}
        public int Codigodebarras {get; set;}
        public string  NomeProduto { get; set;}

        public Produto(int idproduto = 0, int itens = 0, double preco = 0, string descricao = "", int codigodebarras = 0, string nomeProduto = "")
        {
            Idproduto = idproduto;
            Itens = itens;
            Preco = preco;
            Descricao = descricao;
            Codigodebarras = codigodebarras;
            NomeProduto = nomeProduto;
        }
        public  void imprimirdetalhes()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Idproduto: {0}", Idproduto);
            Console.WriteLine("itens: {0}", Itens);
            Console.WriteLine("Preço: {0}", Preco);
            Console.WriteLine("Descrição: {0}", Descricao);
            Console.WriteLine("Codigo de Barras",Codigodebarras);
            Console.WriteLine("Nome do Produto", NomeProduto);
            Console.WriteLine("---------------------------");
        }

    }
}
