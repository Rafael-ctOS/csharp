using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_40
    {
        public void Exercicio40()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 40");
            Console.WriteLine("");

            char resposta;

            do
            {
                Console.Clear();
                VerificarIndicePoluicao();

                Console.Write("Deseja encerrar o programa? (S/N): ");
                resposta = Console.ReadKey().KeyChar;

            } while (resposta != 'S' && resposta != 's');
        }

        static void VerificarIndicePoluicao()
        {
            Console.Write("Informe o índice de poluição medido: ");
            double indicePoluicao = double.Parse(Console.ReadLine());

            if (indicePoluicao >= 0.05 && indicePoluicao <= 0.25)
            {
                Console.WriteLine("Índice de poluição dentro do aceitável.");
            }
            else if (indicePoluicao > 0.25 && indicePoluicao <= 0.3)
            {
                Console.WriteLine("Indústrias do 1º grupo devem suspender suas atividades.");
            }
            else if (indicePoluicao > 0.3 && indicePoluicao <= 0.4)
            {
                Console.WriteLine("Indústrias do 1º e 2º grupo devem suspender suas atividades.");
            }
            else if (indicePoluicao > 0.4 && indicePoluicao <= 0.5)
            {
                Console.WriteLine("Todos os grupos de indústrias devem suspender suas atividades.");
            }
            else if (indicePoluicao > 0.5)
            {
                Console.WriteLine("Índice de poluição atingiu níveis críticos. Todos os grupos devem parar imediatamente.");
            }
            else
            {
                Console.WriteLine("Índice de poluição inválido.");
            }

            Console.WriteLine("");
        }
    }
}