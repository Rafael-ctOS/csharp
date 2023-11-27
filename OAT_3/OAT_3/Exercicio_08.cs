using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_08
    {
        public void Exercicio8()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 08");
            Console.WriteLine("");

            Console.Write("Digite o raio da lata de óleo: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da lata de óleo: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = 3.14159 * raio * raio * altura;

            Console.WriteLine($"O volume da lata de óleo é: {volume}");

            Console.WriteLine("");
        }
    }
}