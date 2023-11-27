using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_1

//3) Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

{
    public class Exercicio_03
    {
        public void Exercicio3()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 03");
            Console.WriteLine("");

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }

            Console.WriteLine("");
        }
    }
}
