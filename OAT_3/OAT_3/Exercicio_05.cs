using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_05
    {
        public void Exercicio5()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 05");
            Console.WriteLine("");

            Console.Write("Informe o tempo gasto na viagem (em horas): ");
            double tempo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a velocidade média (em Km/h): ");
            double velocidadeMedia = Convert.ToDouble(Console.ReadLine());

            // distância usando a fórmula: DISTANCIA = TEMPO * VELOCIDADE
            double distancia = tempo * velocidadeMedia;

            // quantidade de litros de combustível usando a fórmula: LITROS USADOS = DISTANCIA / 12
            double litrosUsados = distancia / 12;

            Console.WriteLine("");

            // apresentar os resultados
            Console.WriteLine("Resultados da Viagem:");
            Console.WriteLine($"Velocidade Média: {velocidadeMedia} Km/h");
            Console.WriteLine($"Tempo Gasto: {tempo} horas");
            Console.WriteLine($"Distância Percorrida: {distancia} Km");
            Console.WriteLine($"Litros Utilizados: {litrosUsados} litros");

            Console.WriteLine("");
        }
    }
}