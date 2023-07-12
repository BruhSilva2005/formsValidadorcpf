using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cliente_produto
{  
    
    public class entidade
    {
         
        static void Main(string[] args)
        {
          

            Cliente cliente = new Cliente();
            cliente.idCliente = 1;
            cliente.Nome = "Bruna da Silva ";
            cliente.Descricao = "alergica a Leite";
            cliente.Cidade = "Marilia";

            cliente.imprimirdetalhes();

            Console.WriteLine("----------------------------");
            Produto produto = new Produto();
            produto.Idproduto = 1;
            produto.Itens = 14;
            produto.Preco = 17.99;
            produto.Descricao = "contem leite e derivados";
            produto.Codigodebarras = 0;
            produto.NomeProduto = "leite";

            produto.imprimirdetalhes();

            Console.WriteLine("----------------------------");


            Venda venda = new Venda();     
            venda.imprimirdetalhes();
            Console.WriteLine("=============================");

        }
    }
}
