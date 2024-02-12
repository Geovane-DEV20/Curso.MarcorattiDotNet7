// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Funcionario funcionario = new Funcionario();
funcionario.Nome = "Josee";
funcionario.Email = "josee@gmail.com";

Console.WriteLine(funcionario.Nome);
Console.WriteLine(funcionario.Email);


Aluno aluno = new Aluno();
aluno.Nota = 10;
aluno.Nome = "Dieguinho";
aluno.Email = "Dieguinho@Hotmail.com";
aluno.Identificar();
public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }

    public void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}

public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }

    public decimal Salario { get; set; }
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}
