using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_29
    {
        public void Exercicio29()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 29");
            Console.WriteLine("");

            int numerosPorLinha = 10;
            int contador = 1;

            for (int i = 1; i <= 2000; i++)
            {
                Console.Write($"{i,5}");

                if (contador % numerosPorLinha == 0)
                {
                    Console.WriteLine(); // Muda para a próxima linha após o número específico por linha
                }

                contador++;
            }

            Console.WriteLine("");
        }
    }
}