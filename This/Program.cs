// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Teste teste = new Teste(Convert.ToInt32(Console.ReadLine()));
public class Aluno
{
    public Aluno(string nome, string sexo, int idade, string aprovado)
    {

        Nome = nome;
        Sexo = sexo;
        Idade = idade;
        Aprovado = aprovado;

    }

    public string? Nome;
    public string? Sexo;
    public int Idade;
    public string? Aprovado;
}

public class Teste
{
    public Teste (int num1, int num2)
    {
        Console.WriteLine($"COnstrutor com dois parametros {num1} e {num2}");
    }

    public Teste(int num) : this(2, 2) 
    {
        Console.WriteLine($"Construtor com o parametro {num}");
    }
}