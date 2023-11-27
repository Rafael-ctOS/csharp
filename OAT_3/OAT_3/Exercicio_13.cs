using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_13
    {
        public void Exercicio13()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 13");
            Console.WriteLine("");

            int num1, num2, num3;

            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            if (num2 < num3)
            {
                int temp = num2;
                num2 = num3;
                num3 = temp;
            }

            if (num1 < num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            Console.WriteLine("");
            Console.WriteLine("Os números em ordem decrescente são: {0}, {1}, {2}", num1, num2, num3);
            Console.WriteLine("");
        }
    }
}