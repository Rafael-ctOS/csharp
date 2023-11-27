using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_53
    {
        public void Exercicio53()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 53");
            Console.WriteLine("");

            Console.Write("Digite o número de voltas: ");
            int numVoltas = int.Parse(Console.ReadLine());

            if (numVoltas <= 0)
            {
                Console.WriteLine("Digite um número válido de voltas.");
                return;
            }

            double[] tempos = new double[numVoltas];

            for (int i = 0; i < numVoltas; i++)
            {
                Console.Write($"Digite o tempo da volta {i + 1} (em segundos): ");
                tempos[i] = double.Parse(Console.ReadLine());
            }

            double melhorTempo = tempos[0];
            int voltaMelhorTempo = 1;

            for (int i = 1; i < numVoltas; i++)
            {
                if (tempos[i] < melhorTempo)
                {
                    melhorTempo = tempos[i];
                    voltaMelhorTempo = i + 1;
                }
            }

            double somaTempos = 0;
            for (int i = 0; i < numVoltas; i++)
            {
                somaTempos += tempos[i];
            }

            double tempoMedio = somaTempos / numVoltas;

            Console.WriteLine("Resultados:");
            Console.WriteLine($"     I. Melhor tempo: {melhorTempo} segundos");
            Console.WriteLine($"    II. Volta do melhor tempo: {voltaMelhorTempo}");
            Console.WriteLine($"   III. Tempo médio das {numVoltas} voltas: {tempoMedio} segundos");

            Console.WriteLine("");
        }
    }
}