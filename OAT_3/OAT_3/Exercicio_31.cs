using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_31
    {
        public void Exercicio31()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 31");
            Console.WriteLine("");

            Console.WriteLine("Digite números positivos. Insira um número negativo para encerrar:");

            int numero;
            int somaPares = 0;
            int somaImpares = 0;

            do
            {
                Console.Write("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        Console.WriteLine($"O número {numero} é par.");
                        somaPares += numero;
                    }
                    else
                    {
                        Console.WriteLine($"O número {numero} é ímpar.");
                        somaImpares += numero;
                    }
                }
                else if (numero < 0)
                {
                    Console.WriteLine("Número negativo inserido. Encerrando a leitura.");
                }
                else
                {
                    Console.WriteLine("Número zero inserido. Apenas números positivos são aceitos.");
                }

            } while (numero >= 0);

            Console.WriteLine($"Soma dos números pares: {somaPares}");
            Console.WriteLine($"Soma dos números ímpares: {somaImpares}");

            Console.WriteLine("");
        }
    }
}