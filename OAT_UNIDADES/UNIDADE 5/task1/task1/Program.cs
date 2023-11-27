using System;
using System.Collections.Generic;

class Carro : IComparable<Carro>
{
    public string Marca { get; set; }
    public double Valor { get; set; }
    public string Cor { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    public Carro(string marca, double valor, string cor, string modelo, int ano)
    {
        Marca = marca;
        Valor = valor;
        Cor = cor;
        Modelo = modelo;
        Ano = ano;
    }

    public int CompareTo(Carro outroCarro)
    {
        return outroCarro.Valor.CompareTo(Valor);
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}, Valor: {Valor:C}, Cor: {Cor}, Modelo: {Modelo}, Ano: {Ano}");
    }
}

class Program
{
    static void Main()
    {
        List<Carro> listaCarros = new List<Carro>();

        while (true)
        {
            Console.Write("Digite a marca do carro (ou 'sair' para encerrar): ");
            string marca = Console.ReadLine();

            if (marca.ToLower() == "sair")
            {
                break;
            }

            Console.Write("Digite o valor do carro: ");
            if (double.TryParse(Console.ReadLine(), out double valor))
            {
                Console.Write("Digite a cor do carro: ");
                string cor = Console.ReadLine();

                Console.Write("Digite o modelo do carro: ");
                string modelo = Console.ReadLine();

                Console.Write("Digite o ano do carro: ");
                if (int.TryParse(Console.ReadLine(), out int ano))
                {
                    Carro novoCarro = new Carro(marca, valor, cor, modelo, ano);

                    listaCarros.Add(novoCarro);
                }
                else
                {
                    Console.WriteLine("Ano inválido. Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
            }
        }

        listaCarros.Sort();

        Console.WriteLine("Carros ordenados por valor (do maior para o menor):");
        foreach (Carro carro in listaCarros)
        {
            carro.ExibirInformacoes();
        }

        Console.ReadLine();
    }
}
