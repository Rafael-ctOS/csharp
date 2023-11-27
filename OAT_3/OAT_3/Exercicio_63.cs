using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_63
    {
        public void Exercicio63()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 63");
            Console.WriteLine("");

            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            string resultado = Verifica(numero);

            Console.WriteLine($"O número {numero} é {resultado}.");

            Console.WriteLine("");
        }

        static string Verifica(int numero)
        {
            return (numero % 2 == 0) ? "PAR" : "ÍMPAR";
        }
    }
}