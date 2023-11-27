using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_59
    {
        public void Exercicio59()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 59");
            Console.WriteLine("");

            Console.Write("Digite o primeiro caractere (A-Z): ");
            char char1 = char.ToUpper(Console.ReadKey().KeyChar);

            Console.Write("Digite o segundo caractere (A-Z): ");
            char char2 = char.ToUpper(Console.ReadKey().KeyChar);

            Console.WriteLine("");

            if (char1 >= 'A' && char1 <= 'Z' && char2 >= 'A' && char2 <= 'Z' && char1 <= char2)
            {
                int numeroCaracteresEntre = char2 - char1 - 1;
                Console.WriteLine($"O número de caracteres entre {char1} e {char2} é: {numeroCaracteresEntre}");
            }
            else
            {
                Console.WriteLine("Erro: Certifique-se de que os caracteres estão em ordem alfabética.");
            }

            Console.WriteLine("");
        }
    }
}