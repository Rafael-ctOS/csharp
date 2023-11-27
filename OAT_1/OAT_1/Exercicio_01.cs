using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_1

//1) Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

{
    public class Exercicio_01
    {
        public void Exercicio1()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 01");
            Console.WriteLine("");


            Console.WriteLine("Digite o valor de A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            int c = int.Parse(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine("A soma de A + B é menor que C.");
            }
            else
            {
                Console.WriteLine("A soma de A + B não é menor que C.");
            }


            Console.WriteLine("");
        }
    }
}
