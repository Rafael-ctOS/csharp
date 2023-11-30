using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_04
    {
        public void Exercicio4()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 04");
            Console.WriteLine("");

            Console.WriteLine("Digite quatro valores inteiros:");
            Console.Write("Valor A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Valor B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Valor C: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Valor D: ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Resultados das adições:");
            Console.WriteLine($"A + B = {a + b}");
            Console.WriteLine($"A + C = {a + c}");
            Console.WriteLine($"A + D = {a + d}");
            Console.WriteLine($"B + C = {b + c}");
            Console.WriteLine($"B + D = {b + d}");
            Console.WriteLine($"C + D = {c + d}");

            Console.WriteLine("");

            Console.WriteLine("Resultados das multiplicações:");
            Console.WriteLine($"A * B = {a * b}");
            Console.WriteLine($"A * C = {a * c}");
            Console.WriteLine($"A * D = {a * d}");
            Console.WriteLine($"B * C = {b * c}");
            Console.WriteLine($"B * D = {b * d}");
            Console.WriteLine($"C * D = {c * d}");

            Console.WriteLine("");
        }
    }
}