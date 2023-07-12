using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cliente_produto
{
    internal class Cliente : Produto
    {
        
        public int idCliente { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Cidade { get; set; }


        public Cliente(int idcliente = 0, string nome = "", string descricao = "", string cidade = "")
        {
            idCliente = idcliente;
            Nome = nome;
            Descricao = descricao;
            Cidade = cidade;
        }

        public virtual void imprimirdetalhes()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Identificação: {0}",idCliente);
            Console.WriteLine("nome: {0}", Nome);
            Console.WriteLine("Descrição: {0}", Descricao);
            Console.WriteLine("Cidade: {0}",Cidade);
            Console.WriteLine("---------------------------");
        }

       
    }
}
