using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_06
    {
        public void Exercicio6()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 06");
            Console.WriteLine("");

            // solicitar ao usuário a entrada da temperatura em graus Celsius
            Console.Write("Digite a temperatura em graus Celsius: ");
            double temperaturaCelsius = Convert.ToDouble(Console.ReadLine());

            // chamar a função para converter Celsius para Fahrenheit
            double temperaturaFahrenheit = ConverterCelsiusParaFahrenheit(temperaturaCelsius);

            // resultado
            Console.WriteLine($"A temperatura em Fahrenheit é: {temperaturaFahrenheit} °F");

            Console.WriteLine("");
        }

        // converter Celsius para Fahrenheit
        static double ConverterCelsiusParaFahrenheit(double temperaturaCelsius)
        {
            return (9 * temperaturaCelsius + 160) / 5;
        }
    }
}