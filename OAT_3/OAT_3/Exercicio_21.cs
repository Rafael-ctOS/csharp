using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_21
    {
        public void Exercicio21()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 21");
            Console.WriteLine("");

            int numero;

            do
            {
                Console.WriteLine("Digite um número inteiro (digite 0 para sair): ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero > 0)
                    {
                        Console.WriteLine("O número é positivo.");
                    }
                    else if (numero < 0)
                    {
                        Console.WriteLine("O número é negativo.");
                    }
                    else
                    {
                        Console.WriteLine("O número é zero.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                }

            } while (numero != 0);

            Console.WriteLine("");
        }
    }
}