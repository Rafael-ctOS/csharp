using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_1

//4) Faça um algoritmo que leia dois valores inteiros A e B se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.

{
    public class Exercicio_04
    {
        public void Exercicio4()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 04");
            Console.WriteLine("");

            Console.WriteLine("Digite o valor de A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int B = int.Parse(Console.ReadLine());

            int C; //armazenar o resultado

            if (A == B)
            {
                //se igual somar valores
                C = A + B;
            }
            else
            {
                //se diferente, multiplica-los
                C = A * B;
            }

            Console.WriteLine("O resultado é: " + C);
    
            Console.WriteLine("");
        }
    }
}
