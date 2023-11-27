using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_48
    {
        public void Exercicio48()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 48");
            Console.WriteLine("");

            int quantidadeCandidatas = 20;
            string[] nomes = new string[quantidadeCandidatas];
            int[] idades = new int[quantidadeCandidatas];

            PreencherCandidatas(nomes, idades);

            ImprimirCandidatasAptas(nomes, idades);
        }

        static void PreencherCandidatas(string[] nomes, int[] idades)
        {
            Console.WriteLine("Preencha as informações das candidatas:");

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Informe o nome da candidata {i + 1}: ");
                nomes[i] = Console.ReadLine();

                Console.Write($"Informe a idade da candidata {i + 1}: ");
                idades[i] = int.Parse(Console.ReadLine());
            }
        }

        static void ImprimirCandidatasAptas(string[] nomes, int[] idades)
        {
            Console.WriteLine("Candidatas aptas à campanha milionária:");


            for (int i = 0; i < nomes.Length; i++)
            {
                if (idades[i] >= 18 && idades[i] <= 20)
                {
                    Console.WriteLine($"{nomes[i]}, {idades[i]} anos");
                }

                Console.WriteLine("");
            }
        }
    }
}