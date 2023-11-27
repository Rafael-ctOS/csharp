using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_47
    {
        public void Exercicio47()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 47");
            Console.WriteLine("");

            int tamanho = 10;
            int[] vetor = new int[tamanho];

            PreencherVetor(vetor);

            Console.Write("Informe um número X: ");
            int numeroX = int.Parse(Console.ReadLine());

            int maioresQueX = ContarMaioresQueX(vetor, numeroX);
            int menoresQueX = ContarMenoresQueX(vetor, numeroX);
            int iguaisAX = ContarIguaisAX(vetor, numeroX);

            Console.WriteLine($"Quantidade de números maiores que {numeroX}: {maioresQueX}");
            Console.WriteLine($"Quantidade de números menores que {numeroX}: {menoresQueX}");
            Console.WriteLine($"Quantidade de números iguais a {numeroX}: {iguaisAX}");
            Console.WriteLine("");
        }

        static void PreencherVetor(int[] vetor)
        {
            Console.WriteLine("Preencha o vetor com 10 números inteiros positivos maiores que zero:");
            for (int i = 0; i < vetor.Length; i++)
            {
                do
                {
                    Console.Write($"Informe o elemento {i + 1}: ");
                    vetor[i] = int.Parse(Console.ReadLine());
                } while (vetor[i] <= 0);
            }
        }

        static int ContarMaioresQueX(int[] vetor, int x)
        {
            int contador = 0;
            foreach (var numero in vetor)
            {
                if (numero > x)
                {
                    contador++;
                }
            }
            return contador;
        }

        static int ContarMenoresQueX(int[] vetor, int x)
        {
            int contador = 0;
            foreach (var numero in vetor)
            {
                if (numero < x)
                {
                    contador++;
                }
            }
            return contador;
        }

        static int ContarIguaisAX(int[] vetor, int x)
        {
            int contador = 0;
            foreach (var numero in vetor)
            {
                if (numero == x)
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}