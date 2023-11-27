using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_12
    {
        public void Exercicio12()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 12");
            Console.WriteLine("");

            Console.Write("Digite um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int modulo = CalcularModulo(numero);

            Console.WriteLine($"O módulo do número {numero} é: {modulo}");

            Console.WriteLine("");
        }

        static int CalcularModulo(int x)
        {
            // Verifica se o número é menor que zero e calcula o módulo apropriado
            if (x < 0)
            {
                return x * (-1);
            }
            else
            {
                // Se o número for maior ou igual a zero, o módulo é o próprio número
                return x;
            }



            
        }
    }
}