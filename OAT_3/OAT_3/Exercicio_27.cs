using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_27
    {
        public void Exercicio27()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 27");
            Console.WriteLine("");

            Console.WriteLine("Digite a quantidade de números a serem processados:");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número #{i + 1}:");
                int numero = Convert.ToInt32(Console.ReadLine());

                long fatorial = CalcularFatorial(numero);

                Console.WriteLine($"O fatorial de {numero} é {fatorial}");
            }
        }

        static long CalcularFatorial(int numero)
        {
            if (numero < 0)
            {
                // Não é possível calcular o fatorial de números negativos
                return -1;
            }

            long resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;



            Console.WriteLine("");
        }
    }
}