using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_1

//7) Faça um algoritmo que leia uma variável e some 5, caso seja par ou some 8, caso seja ímpar, imprimir o resultado desta operação.

{
    public class Exercicio_07
    {
        public void Exercicio7()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 07");
            Console.WriteLine("");

            {
                Console.Write("Digite um número inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    numero += 5;
                }
                else
                {
                    numero += 8;
                }

                Console.WriteLine("O resultado é: " + numero);
            }



            Console.WriteLine("");
        }
    }
}
