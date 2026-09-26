using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contagem10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int contador = 100; contador >= 0; contador -= 10)
            {
                Console.Write($"{contador}.. ");
            }
            Console.WriteLine("Acabou");
        }
    }
}
