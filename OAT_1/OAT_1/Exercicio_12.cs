using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OAT_1

    //12) Escreva um algoritmo que leia o número de identificação, as 3 notas obtidas por um aluno nas 3 verificações e a média dos exercícios que fazem parte da avaliação, e calcule a média de aproveitamento, usando a fórmula:
    //MA = (nota1 + nota 2 * 2 + nota 3 * 3 + ME)/7
    //A atribuição dos conceitos obedece a tabela abaixo.O algoritmo deve escrever o número do aluno, suas notas, a média dos exercícios, a média de aproveitamento, o conceito correspondente e a mensagem 'Aprovado' se o conceito for A, B ou C, e 'Reprovado' se o conceito for D ou E.
    //Média de aproveitamento Conceito
    //>= 90 A
    //>= 75 e< 90 B
    //>= 60 e< 75 C
    //>= 40 e< 60 D
    //< 40 E

{
    public class Exercicio_12
    {
        public void Exercicio12()
        {
                Console.WriteLine("");
                Console.WriteLine("EXERCICIO 12");
                Console.WriteLine("");

                int numeroDeIdentificacao;
                double nota1, nota2, nota3, mediaExercicios, mediaAproveitamento;
                char conceito;

                Console.Write("Digite o número de identificação do aluno: ");
                numeroDeIdentificacao = int.Parse(Console.ReadLine());

                Console.Write("Digite a primeira nota: ");
                nota1 = double.Parse(Console.ReadLine());

                Console.Write("Digite a segunda nota: ");
                nota2 = double.Parse(Console.ReadLine());

                Console.Write("Digite a terceira nota: ");
                nota3 = double.Parse(Console.ReadLine());

                Console.Write("Digite a média dos exercícios: ");
                mediaExercicios = double.Parse(Console.ReadLine());

                mediaAproveitamento = (nota1 + nota2 * 2 + nota3 * 3 + mediaExercicios) / 7;

                if (mediaAproveitamento >= 90)
                {
                    conceito = 'A';
                }
                else if (mediaAproveitamento >= 75)
                {
                    conceito = 'B';
                }
                else if (mediaAproveitamento >= 60)
                {
                    conceito = 'C';
                }
                else if (mediaAproveitamento >= 40)
                {
                    conceito = 'D';
                }
                else
                {
                    conceito = 'E';
                }

                string status = (conceito == 'A' || conceito == 'B' || conceito == 'C') ? "Aprovado" : "Reprovado";

                Console.WriteLine("");

                Console.WriteLine($"Número de Identificação: {numeroDeIdentificacao}");
                Console.WriteLine($"Notas: {nota1}, {nota2}, {nota3}");
                Console.WriteLine($"Média dos exercícios: {mediaExercicios}");
                Console.WriteLine($"Média de Aproveitamento: {mediaAproveitamento}");
                Console.WriteLine($"Conceito: {conceito}");
                Console.WriteLine($"Status: {status}");

                Console.WriteLine("");
        }
    }
}
