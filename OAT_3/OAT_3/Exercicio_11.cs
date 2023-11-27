using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_11
    {
        public void Exercicio11()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 11");
            Console.WriteLine("");

            Console.Write("Digite o valor para A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor para B: ");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            int temp = A;
            A = B;
            B = temp;

            Console.WriteLine("Valores trocados:");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

            Console.WriteLine("");
        }
    }
}