using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cliente_produto
{
    internal class Venda: Cliente
    {
        public string cliente {get;set;}
        public string produto { get;set;}

        public Venda(string Cliente = "" , string Produto = "" )
        {
           this.cliente = Cliente;
           this.produto = Produto;         
        }
        public override void imprimirdetalhes()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Cliente: {0}", cliente);
            Console.WriteLine("Produto: {0}", produto);
            Console.WriteLine("---------------------------");
        }

    }
}
