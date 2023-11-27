using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_39
    {
        public void Exercicio39()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 39");
            Console.WriteLine("");

            char resposta;

            do
            {
                Console.Clear();
                VerificarNumero();

                Console.Write("Deseja encerrar o programa? (S/N): ");
                resposta = Console.ReadKey().KeyChar;

            } while (resposta != 'S' && resposta != 's');
        }

        static void VerificarNumero()
        {
            Console.Write("Informe um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            // Verifica se o número é par ou ímpar
            string parOuImpar = numero % 2 == 0 ? "Par" : "Ímpar";

            // Verifica se o número é positivo, negativo ou zero
            string positivoOuNegativo = numero > 0 ? "Positivo" : (numero < 0 ? "Negativo" : "Zero");

            Console.WriteLine($"O número {numero} é {parOuImpar} e {positivoOuNegativo}.");

            Console.WriteLine("");
        }
    }
}