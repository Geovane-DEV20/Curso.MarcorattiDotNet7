// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int x = 100;
Pessoa p1 = new Pessoa();
p1.nome = "Geovane";
p1.idade = 24;
p1.sexo = "M";

Console.WriteLine($"Nome: {p1.nome} {p1.idade} {p1.sexo}");


Pessoa p2 = p1;
Console.WriteLine($"{p2.nome} {p2.idade} {p2.sexo}");
public class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}