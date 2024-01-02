// See https://aka.ms/new-console-template for more information
using Metodos;

Console.WriteLine("Hello, World!");


public class Aluno
{

    public string? Nome;
    public string? Sexo;
    public int Idade;
    public string? Aprovado;

    public void Consultar()
    {

        MinhaClasse minhaClasse = new MinhaClasse();
        minhaClasse.Saudacao();
        minhaClasse.ExibirDataAtual();

        MinhaClasse minhaClasse1 = new MinhaClasse();
        minhaClasse1.Saudacao("Geovane", DateTime.Now.ToShortTimeString());

        var aluno = new Aluno();
        Console.WriteLine("Nome: ");
        aluno.Nome = Console.ReadLine();

        Console.WriteLine("Idade: ");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sexo: ");
        aluno.Sexo = Console.ReadLine();

        Console.WriteLine("Aprovado");
        aluno.Aprovado = Console.ReadLine();

        minhaClasse1.Resultado(aluno);
    }
}