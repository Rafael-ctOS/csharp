using System;
using System.Collections.Generic;

interface IOperacoesCarro
{
    void CadastrarCarro(List<Carro> listaCarros);
    void ExcluirCarro(List<Carro> listaCarros);
    void ListarCarros(List<Carro> listaCarros);
}

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
        return Valor.CompareTo(outroCarro.Valor);
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}, Valor: {Valor:C}, Cor: {Cor}, Modelo: {Modelo}, Ano: {Ano}");
    }
}

class Program : IOperacoesCarro
{
    static void Main()
    {
        List<Carro> listaCarros = new List<Carro>();
        Program programa = new Program();

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Cadastrar Carro");
            Console.WriteLine("2. Excluir Carro");
            Console.WriteLine("3. Listar Carros (do menor valor para o maior valor)");
            Console.WriteLine("4. Sair");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    programa.CadastrarCarro(listaCarros);
                    break;
                case "2":
                    programa.ExcluirCarro(listaCarros);
                    break;
                case "3":
                    programa.ListarCarros(listaCarros);
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    public void CadastrarCarro(List<Carro> listaCarros)
    {
        Console.Write("Digite a marca do carro: ");
        string marca = Console.ReadLine();

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
                Console.WriteLine("Carro cadastrado com sucesso.");
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

    public void ExcluirCarro(List<Carro> listaCarros)
    {
        if (listaCarros.Count == 0)
        {
            Console.WriteLine("Não há carros cadastrados para excluir.");
            return;
        }

        Console.WriteLine("Lista de carros disponíveis para exclusão:");
        for (int i = 0; i < listaCarros.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {listaCarros[i].Marca} - {listaCarros[i].Modelo}");
        }

        Console.Write("Digite o número do carro que deseja excluir: ");
        if (int.TryParse(Console.ReadLine(), out int numeroCarro) && numeroCarro >= 1 && numeroCarro <= listaCarros.Count)
        {
            Carro carroExcluir = listaCarros[numeroCarro - 1];
            listaCarros.Remove(carroExcluir);
            Console.WriteLine($"Carro {carroExcluir.Marca} - {carroExcluir.Modelo} excluído com sucesso.");
        }
        else
        {
            Console.WriteLine("Número inválido. Tente novamente.");
        }
    }

    public void ListarCarros(List<Carro> listaCarros)
    {
        if (listaCarros.Count == 0)
        {
            Console.WriteLine("Não há carros cadastrados para listar.");
            return;
        }

        listaCarros.Sort();

        Console.WriteLine("Carros ordenados por valor (do menor para o maior):");
        foreach (Carro carro in listaCarros)
        {
            carro.ExibirInformacoes();
        }
    }
}
