using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_1

    //11) Elabore um algoritmo que calcule o que deve ser pago por um produto, considerando o preço normal de etiqueta e a escolha da condição de pagamento.
    //Utilize os códigos da tabela a seguir para ler qual a condição de pagamento escolhida e efetuar o cálculo adequado.
    //Código Condição de pagamento
    //1 À vista em dinheiro ou cheque, recebe 10% de desconto
    //2 À vista no cartão de crédito, recebe 15% de desconto
    //3 Em duas vezes, preço normal de etiqueta sem juros
    //4 Em duas vezes, preço normal de etiqueta mais juros de 10%

{
    public class Exercicio_11
    {
        public void Exercicio11()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 11");
            Console.WriteLine("");

            {
                double precoEtiqueta, valorPago;
                int opcaoPagamento;

                Console.Write("Digite o preço da etiqueta do produto: ");
                precoEtiqueta = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escolha a condição de pagamento:");
                Console.WriteLine("1 - À vista em dinheiro ou cheque (10% de desconto)");
                Console.WriteLine("2 - À vista no cartão de crédito (15% de desconto)");
                Console.WriteLine("3 - Em duas vezes (sem juros)");
                Console.WriteLine("4 - Em duas vezes (com 10% de juros)");
                Console.Write("Opção: ");
                opcaoPagamento = Convert.ToInt32(Console.ReadLine());

                switch (opcaoPagamento)
                {
                    case 1:
                        valorPago = precoEtiqueta * 0.9;
                        break;
                    case 2:
                        valorPago = precoEtiqueta * 0.85;
                        break;
                    case 3:
                        valorPago = precoEtiqueta;
                        break;
                    case 4:
                        valorPago = precoEtiqueta * 1.1;
                        break;
                    default:
                        Console.WriteLine("Opção de pagamento inválida");
                        return;
                }

                Console.WriteLine("O valor a ser pago é: R$" + valorPago);
            }


            Console.WriteLine("");
        }
    }
}
