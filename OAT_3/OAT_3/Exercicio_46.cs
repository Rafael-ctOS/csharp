using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_46
    {
        public void Exercicio46()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 46");
            Console.WriteLine("");

            Console.Write("Informe o tamanho dos vetores: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetorX = new int[tamanho];
            int[] vetorY = new int[tamanho];

            PreencherVetor("X", vetorX);
            PreencherVetor("Y", vetorY);

            int produtoEscalar = CalcularProdutoEscalar(vetorX, vetorY);

            Console.WriteLine($"O produto escalar dos vetores X e Y é: {produtoEscalar}");
        }

        static void PreencherVetor(string nomeVetor, int[] vetor)
        {
            Console.WriteLine($"Preencha o vetor {nomeVetor}:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Informe o elemento {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }

        static int CalcularProdutoEscalar(int[] vetorX, int[] vetorY)
        {
            if (vetorX.Length != vetorY.Length)
            {
                throw new ArgumentException("Os vetores devem ter o mesmo tamanho.");
            }

            int produtoEscalar = 0;

            for (int i = 0; i < vetorX.Length; i++)
            {
                produtoEscalar += vetorX[i] * vetorY[i];
            }

            return produtoEscalar;
        }
    }
}