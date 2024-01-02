// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Email email = new Email();
email.Enviar("Empresa.com.br");
email.Enviar("Empresa.com.br", "Proposta Comercial");
email.Enviar(10, "Proposta Comercial");

public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Assunto Padrao");

    }

    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
    }

    public void Enviar(decimal valor, string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Proposta Fornecedor");
        Console.WriteLine($"{valor}");
    }
}