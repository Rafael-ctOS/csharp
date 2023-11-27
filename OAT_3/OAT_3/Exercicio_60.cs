using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_60
    {
        public void Exercicio60()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 60");
            Console.WriteLine("");

            Console.Write("Digite o valor de x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de y: ");
            double y = double.Parse(Console.ReadLine());

            int quadrante = VerificaQuadrante(x, y);

            Console.WriteLine($"O ponto ({x}, {y}) está no {quadrante}º quadrante.");

            Console.WriteLine("");
        }

        static int VerificaQuadrante(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }
    }
}