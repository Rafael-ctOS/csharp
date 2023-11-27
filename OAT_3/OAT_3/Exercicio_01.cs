using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_01
    {
        public void Exercicio1()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 01");
            Console.WriteLine("");

            {
                Console.WriteLine("Informe a quantidade mínima de peças em estoque:");
                int quantidadeMinima = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a quantidade máxima de peças em estoque:");
                int quantidadeMaxima = int.Parse(Console.ReadLine());

                double estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2.0;

                Console.WriteLine($"O estoque médio da peça é: {estoqueMedio}");
            }



            Console.WriteLine("");
        }
    }
}