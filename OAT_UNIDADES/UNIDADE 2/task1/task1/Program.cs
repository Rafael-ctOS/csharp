using System;

class Carro
{

    public string Modelo { get; set; }
    public string Marca { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; }
    public double Preco { get; set; }


    public Carro(string modelo, string marca, int ano, string cor, double preco)
    {
        Modelo = modelo;
        Marca = marca;
        Ano = ano;
        Cor = cor;
        Preco = preco;
    }
}

class Program
{
    static void Main()
    {

        Carro carro1 = new Carro("Civic", "Honda", 2022, "Prata", 80000.0);
        Carro carro2 = new Carro("Corolla", "Toyota", 2021, "Preto", 85000.0);
        Carro carro3 = new Carro("Golf", "Volkswagen", 2020, "Azul", 75000.0);

        Console.WriteLine("Carro 1:");
        ImprimirCarro(carro1);
        Console.WriteLine();

        Console.WriteLine("Carro 2:");
        ImprimirCarro(carro2);
        Console.WriteLine();

        Console.WriteLine("Carro 3:");
        ImprimirCarro(carro3);
        Console.WriteLine();
    }

    static void ImprimirCarro(Carro carro)
    {
        Console.WriteLine($"Modelo: {carro.Modelo}");
        Console.WriteLine($"Marca: {carro.Marca}");
        Console.WriteLine($"Ano: {carro.Ano}");
        Console.WriteLine($"Cor: {carro.Cor}");
        Console.WriteLine($"Preço: R${carro.Preco:F2}");
    }
}
