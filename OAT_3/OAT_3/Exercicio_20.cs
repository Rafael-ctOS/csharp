using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_20
    {
        public void Exercicio20()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 20");
            Console.WriteLine("");

            int a, b, c;

            do
            {
                Console.Write("Digite um valor maior que zero para a: ");
            } while (!int.TryParse(Console.ReadLine(), out a) || a <= 0);

            do
            {
                Console.Write("Digite um valor maior que zero para b: ");
            } while (!int.TryParse(Console.ReadLine(), out b) || b <= 0);

            do
            {
                Console.Write("Digite um valor maior que zero para c: ");
            } while (!int.TryParse(Console.ReadLine(), out c) || c <= 0);

            int menor = Math.Min(Math.Min(a, b), c);
            int maior = Math.Max(Math.Max(a, b), c);

            Console.WriteLine($"Menor valor: {menor}");
            Console.WriteLine($"Maior valor: {maior}");
            Console.WriteLine($"Menor valor multiplicado pelo maior: {menor * maior}");

            if (menor != 0)
            {
                Console.WriteLine($"Maior valor dividido pelo menor: {maior / (double)menor}");
            }
            else
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }

            Console.WriteLine("");
        }
    }
}