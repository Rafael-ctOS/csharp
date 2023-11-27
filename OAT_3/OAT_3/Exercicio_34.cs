using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_34
    {
        public void Exercicio34()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 34");
            Console.WriteLine("");

            Console.WriteLine("Digite números positivos. Insira um número negativo para encerrar:");

            int numero;
            int menor = int.MaxValue;
            int maior = int.MinValue;

            do
            {
                Console.Write("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero >= 0)
                {
                    if (numero < menor)
                    {
                        menor = numero;
                    }

                    if (numero > maior)
                    {
                        maior = numero;
                    }
                }
                else if (numero < 0)
                {
                    Console.WriteLine("Número negativo inserido. Encerrando a leitura.");
                }
                else
                {
                    Console.WriteLine("Número zero inserido. Apenas números positivos são aceitos.");
                }

            } while (numero >= 0);

            if (menor != int.MaxValue && maior != int.MinValue)
            {
                Console.WriteLine($"Menor número: {menor}");
                Console.WriteLine($"Maior número: {maior}");
            }
            else
            {
                Console.WriteLine("Nenhum número positivo inserido. Não é possível determinar o menor e o maior.");
            }

            Console.WriteLine("");
        }
    }
}