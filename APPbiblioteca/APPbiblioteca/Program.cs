using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPbiblioteca
{
    internal class Program //2
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();
            livro.id = 1;
            livro.titulo = "harry potter";
            livro.Ano = 2021;
            livro.Numerodepagina = 200;

           

            livro.MostrarDetalhes();

           Console.WriteLine("----------------------------");

            LivroDigital livroDigital = new LivroDigital();

            livroDigital.id = 2;
            livroDigital.titulo = "Pequeno Principe";
            livroDigital.Ano = 2012;
            livroDigital.Numerodepagina = 300;
            livroDigital.tipoArquivo = "PDF";
            livroDigital.TamanhoMB = 250;

            livroDigital.MostrarDetalhes();

        }
    }
}
