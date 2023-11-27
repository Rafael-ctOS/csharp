using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_22
    {
        public void Exercicio22()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 22");
            Console.WriteLine("");

            Console.WriteLine("Digite um número: ");

            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                if (numero > 0)
                {
                    double a = numero;
                    Console.WriteLine($"Número positivo. Armazenado em A: {a}");
                }
                else if (numero < 0)
                {
                    double b = numero;
                    Console.WriteLine($"Número negativo. Armazenado em B: {b}");
                }
                else
                {
                    Console.WriteLine("O número é zero.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
            }

            Console.WriteLine("");
        }
    }
}