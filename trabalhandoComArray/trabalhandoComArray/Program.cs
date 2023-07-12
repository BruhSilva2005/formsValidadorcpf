using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhandoComArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o CPF (Apenas Numeros!!): ");
            string cpf = Console.ReadLine();

            char[] numerosCpf = cpf .ToCharArray();

            for (int i = 0; i < numerosCpf.Length; i++)
            {
                Console.WriteLine(numerosCpf[1]);

            }
            Console.WriteLine("================================");

            foreach (char numero in numerosCpf)
            {
                Console.WriteLine(numero);
            }

            int[] numerosInteiros  = numerosCpf.Select(numero => Convert.ToInt32(numero.ToString())).ToArray();
            Console.WriteLine(string.Join("-", numerosInteiros));
        }
    }
}
