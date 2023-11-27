using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_58
    {
        public void Exercicio58()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 58");
            Console.WriteLine("");

            Console.Write("Digite a quantidade de números a serem lidos: ");
            if (int.TryParse(Console.ReadLine(), out int quantidade) && quantidade > 0)
            {
                int[] numeros = new int[quantidade];

                for (int i = 0; i < quantidade; i++)
                {
                    Console.Write($"Digite o número {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
                    {
                        numeros[i] = numero;
                    }
                    else
                    {
                        Console.WriteLine("Digite um número inteiro positivo.");
                        i--;
                    }
                }

                double soma = 0;
                foreach (int numero in numeros)
                {
                    soma += numero;
                }
                double media = soma / quantidade;

                int maiorNumero = EncontrarMaiorNumero(numeros);
                Console.WriteLine($"Média dos números: {media:F2}");
                Console.WriteLine($"Maior número: {maiorNumero}");
            }
            else
            {
                Console.WriteLine("Digite uma quantidade válida de números.");
            }

            Console.WriteLine("");
        }

        static int EncontrarMaiorNumero(int[] array)
        {
            int maior = array[0];
            foreach (int numero in array)
            {
                if (numero > maior)
                {
                    maior = numero;
                }
            }
            return maior;
        }
    }
}