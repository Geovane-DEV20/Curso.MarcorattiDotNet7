// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public struct Cliente
{
    //struct é um tipo de valor
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
            
    }
}