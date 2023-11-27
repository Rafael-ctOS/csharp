using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_64
    {
        private int[] vetor;

        public void Exercicio64()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 64");
            Console.WriteLine("");

            int opcao;

            do
            {
                MostrarMenu();
                opcao = LerOpcao();

                switch (opcao)
                {
                    case 1:
                        CarregarVetor();
                        break;
                    case 2:
                        ListarVetor();
                        break;
                    case 3:
                        ExibirNumerosPares();
                        break;
                    case 4:
                        ExibirNumerosImpares();
                        break;
                    case 5:
                        QuantidadeParesPosicoesImpares();
                        break;
                    case 6:
                        QuantidadeImparesPosicoesPares();
                        break;
                    case 7:
                        Console.WriteLine("Encerrando o programa!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != 7);
        }

        private void MostrarMenu()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Carregar Vetor");
            Console.WriteLine("2 - Listar Vetor");
            Console.WriteLine("3 - Exibir apenas os números pares do vetor");
            Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
            Console.WriteLine("5 - Exibir a quantidade de números pares nas posições ímpares do vetor");
            Console.WriteLine("6 - Exibir a quantidade de números ímpares nas posições pares do vetor");
            Console.WriteLine("7 - Sair");
        }

        private int LerOpcao()
        {
            Console.Write("Digite o número da opção desejada: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private void CarregarVetor()
        {
            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = Convert.ToInt32(Console.ReadLine());

            vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o valor para a posição {i}: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Vetor carregado com sucesso!");
        }

        private void ListarVetor()
        {
            Console.WriteLine("Vetor:");

            foreach (var item in vetor)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }

        private void ExibirNumerosPares()
        {
            Console.WriteLine("Números pares do vetor:");

            foreach (var item in vetor)
            {
                if (item % 2 == 0)
                    Console.Write($"{item} ");
            }

            Console.WriteLine();
        }

        private void ExibirNumerosImpares()
        {
            Console.WriteLine("Números ímpares do vetor:");

            foreach (var item in vetor)
            {
                if (item % 2 != 0)
                    Console.Write($"{item} ");
            }

            Console.WriteLine();
        }

        private void QuantidadeParesPosicoesImpares()
        {
            int count = 0;

            for (int i = 1; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 == 0)
                    count++;
            }

            Console.WriteLine($"Quantidade de números pares nas posições ímpares: {count}");
        }

        private void QuantidadeImparesPosicoesPares()
        {
            int count = 0;

            for (int i = 0; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 != 0)
                    count++;
            }

            Console.WriteLine($"Quantidade de números ímpares nas posições pares: {count}");
        }
    }
}