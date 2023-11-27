using System;

class Program
{
    static void Main()
    {
        int totalPessoas = 200;
        double somaSalarios = 0;
        int somaFilhos = 0;
        double maiorSalario = double.MinValue;
        double menorSalario = double.MaxValue;
        int pessoasAte1500 = 0;

        for (int i = 1; i <= totalPessoas; i++)
        {
            Console.Write($"Digite o salário da pessoa {i}: ");
            if (double.TryParse(Console.ReadLine(), out double salario))
            {
                somaSalarios += salario;
                somaFilhos += SolicitarNumeroFilhos($"Digite o número de filhos da pessoa {i}: ");
                maiorSalario = Math.Max(maiorSalario, salario);
                menorSalario = Math.Min(menorSalario, salario);

                if (salario <= 1500)
                {
                    pessoasAte1500++;
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um salário válido.");
                i--;
            }
        }

        double mediaSalarios = somaSalarios / totalPessoas;
        double mediaFilhos = (double)somaFilhos / totalPessoas;

        double porcentagemAte1500 = (double)pessoasAte1500 / totalPessoas * 100;

        Console.WriteLine($"Média do salário: {mediaSalarios:C}");
        Console.WriteLine($"Média do número de filhos: {mediaFilhos:F}");
        Console.WriteLine($"Maior salário: {maiorSalario:C}");
        Console.WriteLine($"Menor salário: {menorSalario:C}");
        Console.WriteLine($"Porcentagem de pessoas com salários até R$1500,00: {porcentagemAte1500:F}%");

        Console.ReadLine();
    }

    static int SolicitarNumeroFilhos(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);
            if (int.TryParse(Console.ReadLine(), out int numeroFilhos) && numeroFilhos >= 0)
            {
                return numeroFilhos;
            }
            else
            {
                Console.WriteLine("Por favor, digite um número de filhos válido.");
            }
        }
    }
}
