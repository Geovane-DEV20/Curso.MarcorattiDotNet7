// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Aluno aluno = new Aluno("Geovane","M",24,"S");


Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Idade == 0 ? "zero" : aluno.Idade);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);


public class Aluno
{
    //Quando vc nao define um construtor por padrao o valor sera sempre null ou 0
    
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