using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_36
    {
        public void Exercicio36()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 36");
            Console.WriteLine("");

            const int quantidadeValores = 10;
            int[] valores = new int[quantidadeValores];

            // Leitura dos valores
            for (int i = 0; i < quantidadeValores; i++)
            {
                Console.Write($"Digite o valor #{i + 1}: ");
                valores[i] = Convert.ToInt32(Console.ReadLine());

                // Verifica se o valor é positivo
                while (valores[i] <= 0)
                {
                    Console.WriteLine("Digite um valor inteiro e positivo.");
                    Console.Write($"Digite novamente o valor #{i + 1}: ");
                    valores[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Encontrar o maior valor
            int maior = valores[0];
            for (int i = 1; i < quantidadeValores; i++)
            {
                if (valores[i] > maior)
                {
                    maior = valores[i];
                }
            }

            // Encontrar o menor valor
            int menor = valores[0];
            for (int i = 1; i < quantidadeValores; i++)
            {
                if (valores[i] < menor)
                {
                    menor = valores[i];
                }
            }

            // Calcular a média
            double soma = 0;
            for (int i = 0; i < quantidadeValores; i++)
            {
                soma += valores[i];
            }
            double media = soma / quantidadeValores;

            // Exibir resultados
            Console.WriteLine($"Maior valor: {maior}");
            Console.WriteLine($"Menor valor: {menor}");
            Console.WriteLine($"Média dos valores: {media:F2}");
            Console.WriteLine("");
        }
    }
}