using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_1

    //9) Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:
    //para homens: (72.7 * h) – 58;
    //para mulheres: (62.1 * h) – 44.7.

{
    public class Exercicio_09
    {
        public void Exercicio9()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 09");
            Console.WriteLine("");

            {
                Console.WriteLine("Digite a altura em metros (Ex: 1,70): ");
                double altura = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o sexo (M para masculino, F para feminino): ");
                char sexo = char.ToUpper(Console.ReadKey().KeyChar);

                double pesoIdeal = 0;

                if (sexo == 'M')
                {
                    pesoIdeal = (72.7 * altura) - 58;
                }
                else if (sexo == 'F')
                {
                    pesoIdeal = (62.1 * altura) - 44.7;
                }
                else
                {
                    Console.WriteLine("Sexo inválido. Use 'M' para masculino ou 'F' para feminino.");
                    return;
                }

                Console.WriteLine("");
                Console.WriteLine($"Seu peso ideal é: {pesoIdeal} kg");
            }
            Console.WriteLine("");
        }
    }
}
