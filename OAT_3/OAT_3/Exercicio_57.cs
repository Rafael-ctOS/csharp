using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_57
    {
        public void Exercicio57()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 57");
            Console.WriteLine("");

            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            string vogais = ObterVogais(frase);
            Console.WriteLine("Vogais na frase: " + vogais);

            Console.WriteLine("");
        }

        static string ObterVogais(string input)
        {
            string vogais = "";
            foreach (char caracter in input)
            {
                if (EhVogal(caracter))
                {
                    vogais += caracter;
                }
            }
            return vogais;
        }

        static bool EhVogal(char c)
        {
            char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return Array.IndexOf(vogais, c) != -1;
        }
    }
}