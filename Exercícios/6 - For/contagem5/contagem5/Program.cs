using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contagem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int contador = 0; contador <= 40; contador += 5) 
            {
                Console.Write($"{contador}.. ");
                
            }
            Console.Write(" Acabou!");

        }

    }
}
