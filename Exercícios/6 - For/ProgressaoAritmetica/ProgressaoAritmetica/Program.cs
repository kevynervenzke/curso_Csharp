using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressaoAritmetica
{
    internal class Program
    {
        static void menu()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("     Progressão Aritmetica     ");
            Console.WriteLine(" 10 primeiros valores de uma PA");
            Console.WriteLine("===============================");
            Console.WriteLine("1 - Entrar no Programa");
            Console.WriteLine("2 - Sair");
            Console.WriteLine("===============================");
        }
        static void Main(string[] args)
        {
            string RespContinuar = "";
            do
            {
                menu();
                Console.Write("Digite sua Resposta: ");
                int resp = int.Parse(Console.ReadLine());
                Console.WriteLine("===============================");
                switch (resp)
                {
                    case 1:
                        int valor = 0;
                        Console.Write("Qual o 1º termo da PA: ");
                        int PrimeiroPA = int.Parse(Console.ReadLine());
                        Console.Write("Qual a razão da PA: ");
                        int Razao = int.Parse(Console.ReadLine());
                        Console.WriteLine("===============================");
                        Console.Write($"PA Razão {Razao}: [");
                        Console.Write($"{PrimeiroPA}, ");
                        for (int Contador = 1; Contador <= 10; Contador++)
                        {

                            if (Contador < 9)
                            {
                                valor = PrimeiroPA + Razao;
                                PrimeiroPA = valor;
                                Console.Write($"{valor}, ");
                            }
                            if (Contador == 10)
                            {
                                valor += Razao;
                                Console.Write($"{valor}]");
                            }
                        }
                        Console.WriteLine("\n===============================");
                        break;
                    case 2:
                        Console.WriteLine("Fim do Programa!");
                        Console.WriteLine("Pressione a tecla ESC para sair do programa");
                        while (Console.ReadKey(true).Key != ConsoleKey.Escape)
                        {

                        }
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Erro!");
                        Console.WriteLine("\nPressione a tecla ESC para sair do programa");
                        while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
                        break;
                }
            Console.Write("Deseja Continuar? [S/N]: ");
            RespContinuar = Console.ReadLine().ToLower();
                if (RespContinuar == "n")
                {
                    Console.WriteLine("Fim do Programa!");
                    Console.WriteLine("Pressione a tecla ESC para sair do programa");
                    while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
                }
                if (RespContinuar != "s" && RespContinuar != "n")
                {
                    Console.WriteLine("Resposta Inválida!");
                    Console.WriteLine("Pressione a tecla ESC para sair do programa");
                    while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
                }
                
            } while (RespContinuar == "s" || RespContinuar == "n");
          
        }
    }
}
