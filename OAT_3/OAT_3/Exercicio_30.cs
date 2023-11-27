using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_30
    {
        public void Exercicio30()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 30");
            Console.WriteLine("");

            Console.WriteLine("Digite o número para a tabuada:");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Tabuada do {numero}:");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }

            Console.WriteLine("");
        }
    }
}