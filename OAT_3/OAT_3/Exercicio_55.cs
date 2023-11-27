using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_55
    {
        public void Exercicio55()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 55");
            Console.WriteLine("");

            Console.Write("Digite uma frase de até 50 caracteres: ");
            string frase = Console.ReadLine();

            if (frase.Length > 50)
            {
                Console.WriteLine("A frase deve ter no máximo 50 caracteres.");
                return;
            }

            string fraseSemEspacos = RemoverEspacos(frase);

            Console.WriteLine("Frase sem espaços em branco: " + fraseSemEspacos);

            int quantidadeEspacos = ContarEspacos(frase);
            Console.WriteLine($"Quantidade de espaços em branco: {quantidadeEspacos}");

            Console.WriteLine("");
        }

        static string RemoverEspacos(string input)
        {
            return input.Replace(" ", "");
        }

        static int ContarEspacos(string input)
        {
            int contador = 0;
            foreach (char caracter in input)
            {
                if (char.IsWhiteSpace(caracter))
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}