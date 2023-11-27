using System;

public class Carro
{
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public bool EmMovimento { get; private set; }

    public Carro(string modelo, int ano)
    {
        Modelo = modelo;
        Ano = ano;
        EmMovimento = false;
    }

    public string Acelerar()
    {
        if (EmMovimento)
        {
            return "O carro já está em movimento";
        }
        else
        {
            EmMovimento = true;
            return "O carro está em movimento";
        }
    }

    public string Freiar()
    {
        if (EmMovimento)
        {
            EmMovimento = false;
            return "O carro está parado";
        }
        else
        {
            return "O carro já está parado";
        }
    }
}

class Program
{
    static void Main()
    {
        Carro meuCarro = new Carro("Fusca", 2020);

        Console.WriteLine(meuCarro.Acelerar());
        Console.WriteLine(meuCarro.Freiar());
        Console.WriteLine(meuCarro.Freiar());
    }
}
