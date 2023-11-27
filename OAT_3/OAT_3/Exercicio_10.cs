using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_10
    {
        public void Exercicio10()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 10");
            Console.WriteLine("");

            // Solicita ao usuário para inserir dois números inteiros
            Console.Write("Digite o primeiro número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            // Verifica os relacionamentos de ordem e exibe os resultados
            Console.WriteLine("Relacionamentos de ordem:");

            // IGUAL
            Console.WriteLine($"Igual: {numero1 == numero2}");

            // NÃO IGUAL
            Console.WriteLine($"Não igual: {numero1 != numero2}");

            // MAIOR
            Console.WriteLine($"Maior: {numero1 > numero2}");

            // MENOR
            Console.WriteLine($"Menor: {numero1 < numero2}");

            // MAIOR OU IGUAL
            Console.WriteLine($"Maior ou igual: {numero1 >= numero2}");

            //MENOR OU IGUAL
            Console.WriteLine($"Menor ou igual: {numero1 <= numero2}");


            Console.WriteLine("");
        }
    }
}