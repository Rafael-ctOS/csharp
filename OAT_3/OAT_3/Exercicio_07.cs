using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_07
    {
        public void Exercicio7()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 07");
            Console.WriteLine("");

            // temperatura em graus Fahrenheit
            Console.Write("Digite a temperatura em graus Fahrenheit: ");
            double temperaturaFahrenheit = Convert.ToDouble(Console.ReadLine());

            // função para converter Fahrenheit para Celsius
            double temperaturaCelsius = ConverterFahrenheitParaCelsius(temperaturaFahrenheit);

            // resultado
            Console.WriteLine($"A temperatura em Celsius é: {temperaturaCelsius} °C");

            Console.WriteLine("");
        }

        // converter Fahrenheit para Celsius
        static double ConverterFahrenheitParaCelsius(double temperaturaFahrenheit)
        {
            return (temperaturaFahrenheit - 32) * 5 / 9;
        }
    }
}