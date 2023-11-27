using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_18
    {
        public void Exercicio18()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 18");
            Console.WriteLine("");

            Console.WriteLine("Digite um número inteiro (1, 2 ou 3):");
            int codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Um");
                    break;

                case 2:
                    Console.WriteLine("Dois");
                    break;

                case 3:
                    Console.WriteLine("Três");
                    break;

                default:
                    Console.WriteLine("Código inválido");
                    break;
            }

            Console.WriteLine("");
        }
    }
}