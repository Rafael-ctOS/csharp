using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_1

//5) Encontrar o dobro de um número caso ele seja positivo e o seu triplo caso seja negativo, imprimindo o resultado.

{
    public class Exercicio_05
    {
        public void Exercicio5()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 05");
            Console.WriteLine("");

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                int resultado = numero * 2;
                Console.WriteLine("O dobro do número é: " + resultado);
            }
            else
            {
                int resultado = numero * 3;
                Console.WriteLine("O triplo do número é: " + resultado);
            }


            Console.WriteLine("");
        }
    }
}
