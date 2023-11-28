using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_49
    {
        public void Exercicio49()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 49");
            Console.WriteLine("");

            Console.Write("Informe o tamanho dos vetores (até 50): ");
            int tamanho = int.Parse(Console.ReadLine());

            if (tamanho > 50 || tamanho <= 0)
            {
                Console.WriteLine("Tamanho inválido. O tamanho deve ser entre 1 e 50.");
                return;
            }

            int[] V1 = new int[tamanho];
            int[] V2 = new int[tamanho];

            PreencherVetor("V1", V1);
            PreencherVetor("V2", V2);

            int quantidadeIdenticos = ContarValoresIdenticos(V1, V2);
            Console.WriteLine($"Quantidade de valores idênticos nas mesmas posições: {quantidadeIdenticos}");
            Console.WriteLine("");
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

        static int ContarValoresIdenticos(int[] V1, int[] V2)
        {
            int contador = 0;

            for (int i = 0; i < V1.Length; i++)
            {
                if (V1[i] == V2[i])
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}