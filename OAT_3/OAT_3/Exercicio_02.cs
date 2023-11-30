using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_02
    {
        public void Exercicio2()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 02");
            Console.WriteLine("");

            Console.Write("Informe a cotação do dólar: ");
            double CotacaoDolar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor em dólares: ");
            double valorEmDolares = Convert.ToDouble(Console.ReadLine());

            double valorEmReais = valorEmDolares * CotacaoDolar;

            Console.WriteLine($"O valor em reais é: {valorEmReais:C}");


            Console.WriteLine("");
        }
    }
}