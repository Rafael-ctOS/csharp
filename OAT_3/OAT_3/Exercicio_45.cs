using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_45
    {
        public void Exercicio45()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 45");
            Console.WriteLine("");

            Console.Write("Informe o tamanho da sequência de números: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] numeros = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Informe o número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sequência na ordem inversa:");
            for (int i = tamanho - 1; i >= 0; i--)
            {
                Console.Write($"{numeros[i]} ");
            }
            Console.WriteLine("");
        }
    }
}