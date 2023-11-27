using System;

class Program
{
    static void Main()
    {
        double totalComprasAVista = 0;
        double totalComprasAPrazo = 0;
        double totalCompras = 0;

        int totalTransacoes = 15;

        for (int i = 1; i <= totalTransacoes; i++)
        {
            Console.Write($"Digite o código da transação {i} (V para à vista, P para a prazo): ");
            string codigoTransacao = Console.ReadLine().ToUpper();

            Console.Write("Digite o valor da transação: ");

            if (double.TryParse(Console.ReadLine(), out double valorTransacao))
            {
                if (codigoTransacao == "V")
                {
                    totalComprasAVista += valorTransacao;
                }
                else if (codigoTransacao == "P")
                {
                    totalComprasAPrazo += valorTransacao;
                }
                else
                {
                    Console.WriteLine("Código de transação inválido. Use V para à vista ou P para a prazo.");
                    i--;
                }

                totalCompras += valorTransacao;
            }
            else
            {
                Console.WriteLine("Por favor, digite um valor válido.");
                i--;
            }
        }

        Console.WriteLine($"Valor total das compras à vista: {totalComprasAVista}");
        Console.WriteLine($"Valor total das compras a prazo: {totalComprasAPrazo}");
        Console.WriteLine($"Valor total das compras efetuadas: {totalCompras}");

        Console.ReadLine();
    }
}
