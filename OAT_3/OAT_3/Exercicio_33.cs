using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_33
    {
        public void Exercicio33()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 33");
            Console.WriteLine("");

            int contadorAlunos = 0;
            double somaNotas = 0;

            Console.WriteLine("Digite as notas dos alunos. Digite um número de matrícula negativo para encerrar:");

            while (true)
            {
                Console.Write("Número de matrícula (negativo para encerrar): ");
                int matricula = Convert.ToInt32(Console.ReadLine());

                if (matricula < 0)
                {
                    break;
                }

                Console.Write("Nota do aluno: ");
                double nota = Convert.ToDouble(Console.ReadLine());

                if (nota >= 0 && nota <= 10)
                {
                    somaNotas += nota;
                    contadorAlunos++;
                }
                else
                {
                    Console.WriteLine("Nota inválida. A nota deve estar entre 0 e 10.");
                }
            }

            if (contadorAlunos > 0)
            {
                double media = somaNotas / contadorAlunos;
                Console.WriteLine($"Média das notas dos alunos: {media:F2}");
            }
            else
            {
                Console.WriteLine("Nenhum aluno cadastrado. Não é possível calcular a média.");
            }

            Console.WriteLine("");
        }
    }
}