using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPbiblioteca
{
    internal class Livro //1
    {
        public int id { get; set; }
        public string titulo { get; set; }
        private int ano;
        private int numerodepagina;

        public  int Ano
        {
            get { return ano;}
            set
            {
                if (value > 0)
                {
                    ano = value;
                }
                else
                {
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Ano de publicação Invalido!!");
                    
                }
            }

        }

        public int Numerodepagina
        {
            get{return numerodepagina;}
            set
            {
                if(value> 0)
                {
                    numerodepagina=value;
                }
                else
                {
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Ano de Publicação Invalido!!");
                }

            }
        }

        public virtual void MostrarDetalhes()
        {
            Console.WriteLine("id: {0}", id);
            Console.WriteLine("Titulo: {0}", titulo);
            Console.WriteLine("Ano: {0}", ano);
            Console.WriteLine("Número de paginas: {0}", numerodepagina);
        }
    }
}

