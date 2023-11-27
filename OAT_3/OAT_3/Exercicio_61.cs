using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_61
    {
        public void Exercicio61()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 61");
            Console.WriteLine("");

            Console.Write("Digite o valor do salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o índice de reajuste (em percentagem): ");
            double indiceReajuste = double.Parse(Console.ReadLine());

            double salarioAtualizado = Reajuste(salario, indiceReajuste);

            Console.WriteLine($"O salário atualizado é: {salarioAtualizado:C}");

            Console.WriteLine("");
        }

        static double Reajuste(double salario, double indiceReajuste)
        {
            double fatorReajuste = 1 + (indiceReajuste / 100);

            double salarioAtualizado = salario * fatorReajuste;

            return salarioAtualizado;


        }
    }
}