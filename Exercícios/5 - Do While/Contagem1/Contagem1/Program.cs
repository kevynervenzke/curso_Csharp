using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contagem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.WriteLine("Contagem de 3");
            do
            {
                Console.Write($"{contador}.. ");
                contador += 3;
            } while (contador <= 30);
            Console.WriteLine("Acabou!");
        }
    }
}
