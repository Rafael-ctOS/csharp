using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_38
    {
        public void Exercicio38()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 38");
            Console.WriteLine("");

            char resposta;

            do
            {
                Console.Clear();
                CalcularSalario();

                Console.Write("Deseja encerrar o programa? (S/N): ");
                resposta = Console.ReadKey().KeyChar;

            } while (resposta != 'S' && resposta != 's');
        }

        static void CalcularSalario()
        {
            Console.Write("Informe o código do operário: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Informe o número de horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            const double valorPorHoraPadrao = 10.0;
            const double valorPorHoraExcedente = 20.0;
            const int horasLimite = 50;

            double salario = horasTrabalhadas <= horasLimite
                ? horasTrabalhadas * valorPorHoraPadrao
                : horasLimite * valorPorHoraPadrao + (horasTrabalhadas - horasLimite) * valorPorHoraExcedente;

            double salarioExcedente = horasTrabalhadas > horasLimite
                ? (horasTrabalhadas - horasLimite) * valorPorHoraExcedente
                : 0;

            Console.WriteLine($"Salário total: R$ {salario}");
            Console.WriteLine($"Salário excedente: R$ {salarioExcedente}");

            Console.WriteLine("");
        }
    }
}