using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_32
    {
        public void Exercicio32()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 32");
            Console.WriteLine("");

            Console.WriteLine("Digite um número maior que zero e menor que 10:");
            int numeroInicial = Convert.ToInt32(Console.ReadLine());

            if (numeroInicial > 0 && numeroInicial < 10)
            {
                int contador = 0;
                int somaQuadrados = 0;

                Console.WriteLine($"Soma dos quadrados dos 20 primeiros números ímpares a partir de {numeroInicial}:");

                while (contador < 20)
                {
                    if (numeroInicial % 2 != 0)
                    {
                        int quadrado = numeroInicial * numeroInicial;
                        somaQuadrados += quadrado;

                        Console.WriteLine($"Número ímpar: {numeroInicial}, Quadrado: {quadrado}");

                        contador++;
                    }

                    numeroInicial++;
                }

                Console.WriteLine($"Soma total dos quadrados: {somaQuadrados}");
            }
            else
            {
                Console.WriteLine("Número inválido. Certifique-se de que seja maior que zero e menor que 10.");
            }

            Console.WriteLine("");
        }
    }
}