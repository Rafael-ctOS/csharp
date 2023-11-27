using System;

class Program
{
    static void Main()
    {
        int maiorValor = int.MinValue;
        int menorValor = int.MaxValue;
        int somaValores = 0;

        int totalValores = 20;

        int contador = 0;

        do
        {
            Console.Write("Digite um valor inteiro: ");

            if (int.TryParse(Console.ReadLine(), out int valorAtual))
            {
                maiorValor = Math.Max(maiorValor, valorAtual);
                menorValor = Math.Min(menorValor, valorAtual);

                somaValores += valorAtual;

                contador++;
            }
            else
            {
                Console.WriteLine("Por favor, digite um valor inteiro válido.");
            }
        } while (contador < totalValores);

        double mediaValores = (double)somaValores / totalValores;

        Console.WriteLine($"Maior Valor: {maiorValor}");
        Console.WriteLine($"Menor Valor: {menorValor}");
        Console.WriteLine($"Média dos Valores: {mediaValores}");

        Console.ReadLine();
    }
}
