using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_52
    {
        public void Exercicio52()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 52");
            Console.WriteLine("");

            const int maxSize = 100;
            int[] vetor = new int[maxSize];
            int tamanho = 0;

            Console.WriteLine("Digite os números inteiros positivos (digite -1 para sair):");

            int input;
            do
            {
                Console.Write("Número {0}: ", tamanho + 1);
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input == -1)
                    {
                        break;
                    }
                    else if (input > 0)
                    {
                        vetor[tamanho] = input;
                        tamanho++;
                    }
                    else
                    {
                        Console.WriteLine("Digite apenas números inteiros positivos.");
                    }
                }
                else
                {
                    Console.WriteLine("Digite um número válido.");
                }
            } while (tamanho < maxSize);

            int count1 = 0, count3 = 0, count4 = 0;

            for (int i = 0; i < tamanho; i++)
            {
                if (vetor[i] == 1)
                    count1++;
                else if (vetor[i] == 3)
                    count3++;
                else if (vetor[i] == 4)
                    count4++;
            }

            Console.WriteLine("Número de ocorrências:");
            Console.WriteLine("1: {0} vezes", count1);
            Console.WriteLine("3: {0} vezes", count3);
            Console.WriteLine("4: {0} vezes", count4);

            Console.WriteLine("");
        }
    }
}