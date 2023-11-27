using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_25
    {
        public void Exercicio25()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 25");
            Console.WriteLine("");

            Console.WriteLine("Digite a altura (em metros):");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o sexo (M para masculino, F para feminino):");
            char sexo = Convert.ToChar(Console.ReadLine().ToUpper());

            double pesoIdeal;

            if (sexo == 'M')
            {
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine($"O peso ideal para um homem com altura {altura} metros é {pesoIdeal} kg.");
            }
            else if (sexo == 'F')
            {
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine($"O peso ideal para uma mulher com altura {altura} metros é {pesoIdeal} kg.");
            }
            else
            {
                Console.WriteLine("Sexo inválido. Por favor, digite M para masculino ou F para feminino.");
            }

            Console.WriteLine("");
        }
    }
}