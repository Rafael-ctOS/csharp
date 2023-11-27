using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_54
    {
        public void Exercicio54()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 54");
            Console.WriteLine("");

            int[] vetorA = new int[] { 1, 2, 3, 4, 5 };

            int[] vetorB = new int[] { 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Elementos comuns aos dois vetores:");

            foreach (var elementoA in vetorA)
            {
                foreach (var elementoB in vetorB)
                {
                    if (elementoA == elementoB)
                    {
                        Console.WriteLine(elementoA);
                        break;
                    }
                }
            }

            Console.WriteLine("");
        }
    }
}