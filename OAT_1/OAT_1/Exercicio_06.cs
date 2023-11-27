using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_1

//6) Escreva um algoritmo que lê dois valores booleanos (lógicos) e então determina se ambos são VERDADEIROS ou FALSOS.

{
    public class Exercicio_06
    {
        public void Exercicio6()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 06");
            Console.WriteLine("");

            {
                Console.WriteLine("Digite o primeiro valor booleano (true ou false):");
                bool valor1 = bool.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor booleano (true ou false):");
                bool valor2 = bool.Parse(Console.ReadLine());

                bool ambosSaoVerdadeiros = valor1 && valor2;
                bool ambosSaoFalsos = !valor1 && !valor2;

                if (ambosSaoVerdadeiros)
                {
                    Console.WriteLine("Ambos valores são VERDADEIROS.");
                }
                else if (ambosSaoFalsos)
                {
                    Console.WriteLine("Ambos valores são FALSOS.");
                }
                else
                {
                    Console.WriteLine("Um dos valores é VERDADEIRO e o outro é FALSO.");
                }
            }


            Console.WriteLine("");
        }
    }
}
