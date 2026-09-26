using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastrodepessoas
{
    internal class Program
    {
        static void menu()
        {
            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("      Cadastro de Pessoas     ");
            Console.WriteLine("==============================");
            Console.WriteLine("1 - Cadastrar Pessoas         ");
            Console.WriteLine("2 - Sair do Programa          ");
            Console.WriteLine("==============================");
        }
        static void menu2()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("      Cadastro de Pessoas     ");
            Console.WriteLine("==============================");
        }
        static void Main(string[] args)
        {
            string sexo = "";
            float TotalMulheres = 0;
            float TotalPesoMulheres = 0;
            float Homem100 = 0;
            float MaiorHomem = 0;
            menu();
            Console.Write("Escolha sua opção: ");
            int EscolhaMenu = int.Parse(Console.ReadLine());
            switch (EscolhaMenu)
            {
                case 1:
                    Console.Write("Quantas Pessoas deseja Cadastrar? ");
                    int EscolhaContador = int.Parse(Console.ReadLine());
                    for (int contador = 1; contador <= EscolhaContador ; contador++)
                    {
                        Console.Clear();
                        menu2();
                        sexo = "";
                        while (sexo != "m" && sexo != "f")
                        {
                            Console.Write($"Sexo da {contador}ª pessoa [M/F]: ");
                            sexo = Console.ReadLine().ToLower();

                            if (sexo != "m" && sexo != "f")
                            {
                                Console.WriteLine("Resposta Inválida");
                            }
                        }
                        if (sexo == "f")
                        {

                            TotalMulheres++;
                        }
                        Console.Write($"Peso da  {contador}ª pessoa [Kg]: ");
                        float peso = float.Parse(Console.ReadLine());
                        if (peso > 100 && sexo == "m")
                        {
                            Homem100++;
                        }
                        if (peso > MaiorHomem)
                        {
                            MaiorHomem = peso;
                        }
                        if (sexo == "f")
                        {
                            TotalPesoMulheres += peso;
                        }

                    }
                    break;

                case 2:
                    Console.WriteLine("Saindo do Programa...");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Erro!");
                    Console.WriteLine("Saindo do Programa...");
                    Environment.Exit(0);
                    break;
            }

            float MediaPesoMulher = 0;
            MediaPesoMulher = TotalPesoMulheres / TotalMulheres;
            Console.WriteLine("==============================");
            Console.WriteLine($"Mulheres Cadastradas: {TotalMulheres:F0}");
            Console.WriteLine($"Homens com mais de 100Kg: {Homem100}");
            Console.WriteLine($"Média de peso das mulheres: {MediaPesoMulher:F2}");
            Console.WriteLine($"Maior Peso entre homens: {MaiorHomem}");
        }
    }
}
