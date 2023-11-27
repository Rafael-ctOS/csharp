using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_23
    {
        public void Exercicio23()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 23");
            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");

                int escolha;
                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch (escolha)
                    {
                        case 1:
                            RealizarAdicao();
                            break;
                        case 2:
                            RealizarSubtracao();
                            break;
                        case 3:
                            RealizarMultiplicacao();
                            break;
                        case 4:
                            RealizarDivisao();
                            break;
                        case 5:
                            Console.WriteLine("Programa encerrado. Até mais!");
                            return;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }

                Console.WriteLine();
            }
        }

        static void RealizarAdicao()
        {
            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado = numero1 + numero2;
            Console.WriteLine($"Resultado da adição: {resultado}");
        }

        static void RealizarSubtracao()
        {
            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado = numero1 - numero2;
            Console.WriteLine($"Resultado da subtração: {resultado}");
        }

        static void RealizarMultiplicacao()
        {
            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado = numero1 * numero2;
            Console.WriteLine($"Resultado da multiplicação: {resultado}");

            Console.WriteLine("");
        }

        static void RealizarDivisao()
        {
            Console.Write("Digite o numerador: ");
            double numerador = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o denominador: ");
            double denominador;
            if (double.TryParse(Console.ReadLine(), out denominador) && denominador != 0)
            {
                double resultado = numerador / denominador;
                Console.WriteLine($"Resultado da divisão: {resultado}");
            }
            else
            {
                Console.WriteLine("Denominador inválido. Certifique-se de que não seja zero.");
            }
        }
    }
}