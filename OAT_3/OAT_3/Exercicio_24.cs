using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_24
    {
        public void Exercicio24()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 24");
            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine("Digite o primeiro número inteiro:");
                int numero1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o segundo número inteiro:");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Verificar se um dos números é múltiplo do outro");
                Console.WriteLine("2 - Verificar se ambos os números são pares");
                Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7");
                Console.WriteLine("4 - Sair");

                int escolha;
                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch (escolha)
                    {
                        case 1:
                            VerificarMultiplo(numero1, numero2);
                            break;
                        case 2:
                            VerificarPares(numero1, numero2);
                            break;
                        case 3:
                            VerificarMediaMaiorIgualSete(numero1, numero2);
                            break;
                        case 4:
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

        static void VerificarMultiplo(int num1, int num2)
        {
            if (num1 % num2 == 0 || num2 % num1 == 0)
            {
                Console.WriteLine("Um dos números é múltiplo do outro.");
            }
            else
            {
                Console.WriteLine("Nenhum dos números é múltiplo do outro.");
            }
        }

        static void VerificarPares(int num1, int num2)
        {
            if (num1 % 2 == 0 && num2 % 2 == 0)
            {
                Console.WriteLine("Ambos os números são pares.");
            }
            else
            {
                Console.WriteLine("Pelo menos um dos números não é par.");
            }
        }

        static void VerificarMediaMaiorIgualSete(int num1, int num2)
        {
            double media = (num1 + num2) / 2.0;
            if (media >= 7)
            {
                Console.WriteLine($"A média dos dois números é {media}, que é maior ou igual a 7.");
            }
            else
            {
                Console.WriteLine($"A média dos dois números é {media}, que é menor que 7.");
            }

            Console.WriteLine("");
        }
    }
}