using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_62
    {
        public void Exercicio62()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 62");
            Console.WriteLine("");

            Console.Write("Digite o valor da base do triângulo: ");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura do triângulo: ");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            double hipotenusa = CalculaHipotenusa(baseTriangulo, alturaTriangulo);

            Console.WriteLine($"O valor da hipotenusa é: {hipotenusa:F2}");

            Console.WriteLine("");
        }

        static double CalculaHipotenusa(double baseTriangulo, double alturaTriangulo)
        {
            double hipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));

            return hipotenusa;
        }
    }
}