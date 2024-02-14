// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Aluno aluno = new();
aluno.Nome = "Maria";
aluno.Curso = "Quimica";
Console.WriteLine(aluno.Saudacao());
class Pessoa
{
    public string? Nome { get; set; }
    public string Saudacao() => $"Olá meu nome é geovane {Nome}";
}

class Aluno : Pessoa
{
    public string? Curso { get; set; }

    public new string Saudacao() => $"Oi meu nome é {Nome} do curso de {Curso}";
}