using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contagem_inteligente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contagem Inteligente");
            Console.Write("Digite um número: ");
            int ValorFinal = int.Parse(Console.ReadLine());
            for(int contador = 0; contador <= ValorFinal; contador++)
            {
                if (contador == ValorFinal)
                {
                    Console.Write($"{contador} FIM!");
                }
                else
                {
                    Console.Write($"{contador}, ");
                }
            }
        }
    }
}
