using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_17
    {
        public void Exercicio17()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 17");
            Console.WriteLine("");

            Console.Write("Digite um número inteiro: ");
            int numero;

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero >= 0 && numero <= 9)
                {
                    Console.WriteLine("Valor válido");
                }
                else
                {
                    Console.WriteLine("Valor inválido");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }



            Console.WriteLine("");
        }
    }
}