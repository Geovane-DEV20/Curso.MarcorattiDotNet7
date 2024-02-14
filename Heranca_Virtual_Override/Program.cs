// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



class Pessoa
{
    public string? Nome { get; set; }
    public virtual string Saudacao() => $"Olá meu nome é geovane {Nome}";
}



class Aluno : Pessoa
{
    public string? Curso { get; set; }

    public override string Saudacao() => $"Oi meu nome é {Nome} do curso de {Curso}"; // Indica que esse método pode ser substituido
}