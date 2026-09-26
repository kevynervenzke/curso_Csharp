using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("           Tabuada            ");
            Console.WriteLine("==============================");
            Console.Write("Digite um número: ");
            int ValorTabuada = int.Parse(Console.ReadLine());
            Console.WriteLine("==============================");
            for (int Valor = 1;Valor <= 10;Valor++)
            {
                int Produto = Valor * ValorTabuada;
                Console.WriteLine($"{ValorTabuada} x {Valor} = {Produto}");
            }
            
        }
    }
}
