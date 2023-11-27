using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_37
    {
        public void Exercicio37()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 37");
            Console.WriteLine("");

            char resposta;

            do
            {
                Console.Clear();
                MostrarMenu();
                int opcao = ObterOpcao();

                switch (opcao)
                {
                    case 1:
                        RealizarOperacao(Adicao);
                        break;
                    case 2:
                        RealizarOperacao(Subtracao);
                        break;
                    case 3:
                        RealizarOperacao(Multiplicacao);
                        break;
                    case 4:
                        RealizarOperacao(Divisao);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.Write("Deseja voltar ao menu principal? (S/N): ");
                resposta = Console.ReadKey().KeyChar;

            } while (resposta == 'S' || resposta == 's');
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
        }
            
        static int ObterOpcao()
        {
            Console.Write("Informe a opção: ");
            return int.Parse(Console.ReadLine());
        }

        static void RealizarOperacao(Func<double, double, double> operacao)
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = operacao(num1, num2);
            Console.WriteLine($"Resultado: {resultado}");
        }

        static double Adicao(double a, double b)
        {
            return a + b;
        }

        static double Subtracao(double a, double b)
        {
            return a - b;
        }

        static double Multiplicacao(double a, double b)
        {
            return a * b;
        }

        static double Divisao(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Erro: divisão por zero.");
                return 0;
            }
        }
    }
}