using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_19
    {
        public void Exercicio19()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 19");
            Console.WriteLine("");

            Console.WriteLine("Informe os valores dos lados do triângulo:");

            Console.Write("Lado A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Lado B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Lado C: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            if (FormaTriangulo(a, b, c))
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("O triângulo é isósceles.");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os lados fornecidos não formam um triângulo.");
            }
        }

        static bool FormaTriangulo(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}