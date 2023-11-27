using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_16
    {
        public void Exercicio16()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 16");
            Console.WriteLine("");

            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"Maior número: {numero1}");
                Console.WriteLine($"Menor número: {numero2}");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"Maior número: {numero2}");
                Console.WriteLine($"Menor número: {numero1}");
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }



            Console.WriteLine("");
        }
    }
}