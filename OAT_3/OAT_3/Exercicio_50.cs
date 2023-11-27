using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_50
    {
        public void Exercicio50()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 50");
            Console.WriteLine("");

            Random random = new Random();
            int numeroSorteado = random.Next(101);
            int tentativa;
            int tentativasFeitas = 0;

            Console.WriteLine("Tente adivinhar o número sorteado de 0 a 100.");

            do
            {
                Console.Write("Digite sua tentativa: ");
                tentativa = int.Parse(Console.ReadLine());

                tentativasFeitas++;

                if (tentativa < numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é maior. Tente novamente.");
                }
                else if (tentativa > numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é menor. Tente novamente.");
                }

            } while (tentativa != numeroSorteado);

            Console.WriteLine($"Parabéns! Você acertou o número {numeroSorteado} em {tentativasFeitas} tentativas.");

            Console.WriteLine("");
        }
    }
}