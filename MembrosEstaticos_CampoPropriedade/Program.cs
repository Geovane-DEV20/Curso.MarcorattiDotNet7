// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var teste = Cliente.Nome;
teste = "Geovane";

public class Cliente
{
    public static string? Nome;
    public static int Idade;


    public Cliente(string? nome, int idade) 
    { 
        Nome = nome;
        Idade = idade;  
    }
}