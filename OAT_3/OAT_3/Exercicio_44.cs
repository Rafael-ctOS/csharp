using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_44
    {
        public void Exercicio44()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 44");
            Console.WriteLine("");

            char resposta;

            do
            {
                Console.Clear();
                MostrarOpcoes();
                int opcao = ObterOpcao();

                switch (opcao)
                {
                    case 1:
                        ConversaoCelsiusParaFahrenheit();
                        break;
                    case 2:
                        ConversaoFahrenheitParaCelsius();
                        break;
                    case 3:
                        PesoIdealHomem();
                        break;
                    case 4:
                        PesoIdealMulher();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.Write("Deseja encerrar o programa? (S/N): ");
                resposta = Console.ReadKey().KeyChar;

            } while (resposta != 'S' && resposta != 's');
        }

        static void MostrarOpcoes()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
            Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
            Console.WriteLine("3 - Peso ideal do homem");
            Console.WriteLine("4 - Peso ideal da mulher");
        }

        static int ObterOpcao()
        {
            Console.Write("Informe a opção desejada: ");
            return int.Parse(Console.ReadLine());
        }

        static void ConversaoCelsiusParaFahrenheit()
        {
            Console.Write("Informe a temperatura em graus Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}°F");
        }

        static void ConversaoFahrenheitParaCelsius()
        {
            Console.Write("Informe a temperatura em graus Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"A temperatura em Celsius é: {celsius}°C");
        }

        static void PesoIdealHomem()
        {
            Console.Write("Informe a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double pesoIdeal = (72.7 * altura) - 58;

            Console.WriteLine($"O peso ideal para um homem com {altura}m é: {pesoIdeal} kg");

            VerificarPeso(altura, pesoIdeal);
        }

        static void PesoIdealMulher()
        {
            Console.Write("Informe a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double pesoIdeal = (62.1 * altura) - 44.7;

            Console.WriteLine($"O peso ideal para uma mulher com {altura}m é: {pesoIdeal} kg");

            VerificarPeso(altura, pesoIdeal);
        }

        static void VerificarPeso(double altura, double pesoIdeal)
        {
            Console.Write("Informe o peso atual em kg: ");
            double pesoAtual = double.Parse(Console.ReadLine());

            Console.WriteLine($"O peso ideal para você seria: {pesoIdeal} kg");

            if (pesoAtual == pesoIdeal)
            {
                Console.WriteLine("Você está no peso ideal.");
            }
            else if (pesoAtual < pesoIdeal)
            {
                Console.WriteLine("Você está abaixo do peso ideal.");
            }
            else
            {
                Console.WriteLine("Você está acima do peso ideal.");
            }

        Console.WriteLine("");
        }
    }
}