using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_15
    {
        public void Exercicio15()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 15");
            Console.WriteLine("");

            double nota1, nota2, nota3, nota4;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine($"O aluno foi aprovado com média {media:F2}.");
            }
            else
            {
                Console.Write("Digite a nota de recuperação: ");
                double notaRecuperacao = double.Parse(Console.ReadLine());

                double novaMedia = (media + notaRecuperacao) / 2;

                if (novaMedia >= 7)
                {
                    Console.WriteLine($"O aluno foi aprovado na recuperação com média {novaMedia:F2}.");
                }
                else
                {
                    Console.WriteLine($"O aluno não foi aprovado, a média final é {novaMedia:F2}.");
                }
            }

            Console.WriteLine("");
        }
    }
}