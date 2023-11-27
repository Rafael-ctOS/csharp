using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_35
    {
        public void Exercicio35()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 35");
            Console.WriteLine("");

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);

                if (i % 10 == 0)
                {
                    Console.WriteLine("Múltiplo de 10");
                }
            }

            Console.WriteLine("");
        }
    }
}