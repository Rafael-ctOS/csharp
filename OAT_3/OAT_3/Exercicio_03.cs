using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_03
    {
        public void Exercicio3()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 03");
            Console.WriteLine("");

            Console.Write("Digite a identificação do vendedor: ");
            int idVendedor = int.Parse(Console.ReadLine());

            Console.Write("Digite o código da peça: ");
            int codigoPeca = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço unitário da peça: ");
            double precoUnitario = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade vendida: ");
            int quantidadeVendida = int.Parse(Console.ReadLine());

            double totalVenda = precoUnitario * quantidadeVendida;

            double comissao = 0.05 * totalVenda;

            Console.WriteLine("\n--- Resumo da Venda ---");
            Console.WriteLine("Identificação do Vendedor: " + idVendedor);
            Console.WriteLine("Código da Peça: " + codigoPeca);
            Console.WriteLine("Preço Unitário da Peça: R$ " + precoUnitario);
            Console.WriteLine("Quantidade Vendida: " + quantidadeVendida);
            Console.WriteLine("Total de Venda: R$ " + totalVenda);
            Console.WriteLine("Comissão do Vendedor (5%): R$ " + comissao);



            Console.WriteLine("");
        }
    }
}