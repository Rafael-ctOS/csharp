using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_56
    {
        public void Exercicio56()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 56");
            Console.WriteLine("");

            const int tamanhoVetor = 50;
            int[] vetor = new int[tamanhoVetor];

            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.Write($"Digite o valor para a posição {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int valor) && valor > 0)
                {
                    vetor[i] = valor;
                }
                else
                {
                    Console.WriteLine("Digite um número inteiro positivo.");
                    i--;
                }
            }

            int quantidadePares = 0;
            int quantidadeMultiplosDe5 = 0;

            foreach (int numero in vetor)
            {
                if (numero % 2 == 0)
                {
                    quantidadePares++;
                }

                if (numero % 5 == 0)
                {
                    quantidadeMultiplosDe5++;
                }
            }

            Console.WriteLine($"Quantidade de números pares: {quantidadePares}");
            Console.WriteLine($"Quantidade de múltiplos de 5: {quantidadeMultiplosDe5}");


            Console.WriteLine("");
        }
    }
}