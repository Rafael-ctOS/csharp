using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_14
    {
        public void Exercicio14()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 14");
            Console.WriteLine("");

            int num1, num2;

            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            int diferenca;

            if (num1 > num2)
            {
                diferenca = num1 - num2;
                Console.WriteLine("A diferença do maior para o menor é: " + diferenca);
            }
            else if (num2 > num1)
            {
                diferenca = num2 - num1;
                Console.WriteLine("A diferença do maior para o menor é: " + diferenca);
            }
            else
            {
                Console.WriteLine("Os números são iguais, a diferença é zero.");
            }

            Console.WriteLine("");
        }
    }
}