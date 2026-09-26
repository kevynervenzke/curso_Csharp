using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomadorMaster_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float media = 0;
            float ValorSoma = 0;
            float MenorValor = 0;
            float Pares = 0;
            int contador = 0;
            string resp = "s";
            Console.WriteLine("Somador Master");
            do
            {
                contador++;
                Console.Write($"Digite o {contador}º valor: ");
                float valor = float.Parse(Console.ReadLine());
                ValorSoma += valor;
                if (valor < MenorValor || MenorValor == 0)
                {
                    MenorValor = valor;
                }
                if (valor % 2 == 0)
                {
                    Pares++;
                }


                Console.Write("Deseja Continuar? [S/N]");
                resp = Console.ReadLine().ToLower();
                if (resp == "n")
                {
                    media = ValorSoma / contador;
                    Console.WriteLine($"A soma de todos os {contador} valores é: {ValorSoma}");
                    Console.WriteLine($"O menor valor digitador foi {MenorValor}");
                    Console.WriteLine($"A média entre todos os valores é {media:F2}");
                    Console.WriteLine($"O total de valores pares é: {Pares}");
                    Console.WriteLine("Fim do Programa!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (resp != "s" && resp != "n")
                {
                    Console.WriteLine("Resposta Inválida!");
                }



            } while (resp.ToLower() != "n");


        }
    }
}

