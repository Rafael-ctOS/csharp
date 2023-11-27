using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OAT_1

    //10) O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre a condição de peso de uma pessoa adulta. A fórmula é: IMC = peso / ( altura )2
    //Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a tabela abaixo.
    //IMC em adultos Condição
    //Abaixo de 18,5 Abaixo do peso
    //Entre 18,5 e 25 Peso normal
    //Entre 25 e 30 Acima do peso
    //Acima de 30 obeso

{
    public class Exercicio_10
    {
        public void Exercicio10()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 10");
            Console.WriteLine("");

            {

                Console.Write("Informe o peso em quilogramas: ");
                double peso = double.Parse(Console.ReadLine());

                Console.Write("Informe a altura em metros: ");
                double altura = double.Parse(Console.ReadLine());

                double imc = peso / (altura * altura);

                string condicao = "";
                if (imc < 18.5)
                {
                    condicao = "Abaixo do peso";
                }
                else if (imc >= 18.5 && imc < 25)
                {
                    condicao = "Peso normal";
                }
                else if (imc >= 25 && imc < 30)
                {
                    condicao = "Acima do peso";
                }
                else
                {
                    condicao = "Obeso";
                }

                Console.WriteLine($"Seu IMC é {imc:F2} e sua condição é: {condicao}");
            }

            Console.WriteLine("");
        }
    }
}
