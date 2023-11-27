using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_51
    {
        public void Exercicio51()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 51");
            Console.WriteLine("");

            Console.Write("Informe a quantidade de alunos: ");
            int quantidadeAlunos = int.Parse(Console.ReadLine());

            if (quantidadeAlunos <= 0)
            {
                Console.WriteLine("Quantidade inválida. Deve ser maior que zero.");
                return;
            }

            double somaNotas = 0;
            int alunosAcimaDeSete = 0;

            for (int i = 1; i <= quantidadeAlunos; i++)
            {
                Console.Write($"Informe a nota do aluno {i}: ");
                double nota = double.Parse(Console.ReadLine());

                somaNotas += nota;

                if (nota > 7.0)
                {
                    alunosAcimaDeSete++;
                }
            }

            if (alunosAcimaDeSete > 0)
            {
                double media = somaNotas / quantidadeAlunos;
                Console.WriteLine($"Média aritmética das notas: {media:F2}");
                Console.WriteLine($"Número de alunos com nota acima de 7.0: {alunosAcimaDeSete}");
            }
            else
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 7.0.");
            }

            Console.WriteLine("");
        }
    }
}