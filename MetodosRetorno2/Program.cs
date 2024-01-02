// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");
Cadastro cadastro = new();
var cliente = cadastro.Registrar();
cadastro.Exibirdados("Dados do cliente: ", cliente);
//alterar renda
cliente = cadastro.Registrar(cliente);
cadastro.Exibirdados("Renda alterada", cliente);
public class Cliente
{
    public string? Nome;
    public int idade;
    public decimal Renda;

    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        this.idade = idade;
        Renda = renda;
    }
    //Eu consigo instanciar em qualquer classe sem passar valores
    public Cliente()
    {
        
    }
}
public class Cadastro
{
    public Cliente Registrar()
    {
        Cliente cliente = new("Geovane", 24, 3000);
        return cliente;
    }

    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 3500;
        return cliente;
    }
    public void Exibirdados(string? texto, Cliente cliente)
    {
        Console.Write($"\n{texto}\t");
        Console.WriteLine($"{cliente.Nome} {cliente.idade} {cliente.Renda.ToString("c")}"); // c = formato local da moeda
    }
}