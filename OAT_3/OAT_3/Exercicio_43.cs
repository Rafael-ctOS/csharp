using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_43
    {
        public void Exercicio43()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 43");
            Console.WriteLine("");

            Console.WriteLine("Calculadora de grãos de trigo para o monge");

            Console.Write("Informe o número de quadros do tabuleiro de xadrez: ");
            int numeroQuadros = int.Parse(Console.ReadLine());

            long totalGraos = CalcularTotalGraos(numeroQuadros);

            Console.WriteLine($"O monge esperava receber um total de {totalGraos:N0} grãos de trigo.");
            Console.WriteLine("");
        }

        static long CalcularTotalGraos(int numeroQuadros)
        {
            if (numeroQuadros < 1)
            {
                return 0;
            }

            long totalGraos = 1;

            for (int i = 1; i < numeroQuadros; i++)
            {
                totalGraos += (long)Math.Pow(2, i);
            }

            return totalGraos;
        }
    }
}