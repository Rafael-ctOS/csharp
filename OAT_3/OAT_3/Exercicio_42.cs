using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_42
    {
        public void Exercicio42()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 42");
            Console.WriteLine("");

            int numero;
            int maior = int.MinValue;
            int menor = int.MaxValue;

            do
            {
                Console.Write("Informe um número (digite 0 para encerrar): ");
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    if (numero > maior)
                    {
                        maior = numero;
                    }

                    if (numero < menor)
                    {
                        menor = numero;
                    }
                }

            } while (numero != 0);

            if (maior != int.MinValue && menor != int.MaxValue)
            {
                Console.WriteLine($"O maior número é: {maior}");
                Console.WriteLine($"O menor número é: {menor}");
            }
            else
            {
                Console.WriteLine("Nenhum número foi inserido.");
            }

            Console.WriteLine("");
        }
    }
}