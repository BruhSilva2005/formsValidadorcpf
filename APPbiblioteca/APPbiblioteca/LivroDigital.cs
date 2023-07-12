using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPbiblioteca
{
    internal class LivroDigital : Livro
    {
        public string tipoArquivo;
        private int tamanhoMB;
        
        public int TamanhoMB
        {
            get { return tamanhoMB; }
            set 
            {  
                if(value>0)
                {
                    tamanhoMB = value;
                }
                else
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("Tamanho do arquivo Invalido");
                }
               
            }
        }

        public override void MostrarDetalhes()
        {
            base.MostrarDetalhes();
            Console.WriteLine("tamanho:{0} MB", TamanhoMB);
            Console.WriteLine("Tipo de arquivo {0}", tipoArquivo);
        }
        
    }
}
