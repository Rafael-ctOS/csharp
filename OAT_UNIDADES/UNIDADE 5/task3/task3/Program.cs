using System;

class Program
{
    static int[] vetor;

    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Carregar Vetor");
            Console.WriteLine("2. Listar Vetor");
            Console.WriteLine("3. Exibir apenas os números pares do vetor");
            Console.WriteLine("4. Exibir apenas os números ímpares do vetor");
            Console.WriteLine("5. Exibir a quantidade de números pares nas posições ímpares");
            Console.WriteLine("6. Exibir a quantidade de números ímpares nas posições pares");
            Console.WriteLine("7. Sair");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                ExecutarOpcao(opcao);
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        } while (opcao != 7);
    }

    static void ExecutarOpcao(int opcao)
    {
        switch (opcao)
        {
            case 1:
                CarregarVetor();
                break;
            case 2:
                ListarVetor();
                break;
            case 3:
                ExibirPares();
                break;
            case 4:
                ExibirImpares();
                break;
            case 5:
                QuantidadeParesPosicoesImpares();
                break;
            case 6:
                QuantidadeImparesPosicoesPares();
                break;
            case 7:
                Console.WriteLine("Programa encerrado.");
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }

    static void CarregarVetor()
    {
        Console.Write("Digite a quantidade de elementos do vetor: ");
        int tamanho = int.Parse(Console.ReadLine());

        vetor = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Digite o valor para a posição {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Vetor carregado com sucesso.");
    }

    static void ListarVetor()
    {
        if (vetor != null)
        {
            Console.WriteLine("Elementos do vetor:");
            foreach (int elemento in vetor)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Vetor não carregado. Carregue o vetor antes de listar.");
        }
    }

    static void ExibirPares()
    {
        if (vetor != null)
        {
            Console.WriteLine("Números pares do vetor:");
            foreach (int elemento in vetor)
            {
                if (elemento % 2 == 0)
                {
                    Console.Write(elemento + " ");
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Vetor não carregado. Carregue o vetor antes de exibir números pares.");
        }
    }

    static void ExibirImpares()
    {
        if (vetor != null)
        {
            Console.WriteLine("Números ímpares do vetor:");
            foreach (int elemento in vetor)
            {
                if (elemento % 2 != 0)
                {
                    Console.Write(elemento + " ");
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Vetor não carregado. Carregue o vetor antes de exibir números ímpares.");
        }
    }

    static void QuantidadeParesPosicoesImpares()
    {
        if (vetor != null)
        {
            int count = 0;
            for (int i = 1; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Quantidade de números pares nas posições ímpares: {count}");
        }
        else
        {
            Console.WriteLine("Vetor não carregado. Carregue o vetor antes de contar números pares nas posições ímpares.");
        }
    }

    static void QuantidadeImparesPosicoesPares()
    {
        if (vetor != null)
        {
            int count = 0;
            for (int i = 0; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Quantidade de números ímpares nas posições pares: {count}");
        }
        else
        {
            Console.WriteLine("Vetor não carregado. Carregue o vetor antes de contar números ímpares nas posições pares.");
        }
    }
}
