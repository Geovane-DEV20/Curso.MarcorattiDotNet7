// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Email email = new Email();
email.Enviar(destino: "geovane@teste.com", titulo: "teste", assunto: "teste do teste");

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"{destino}, {titulo}:{assunto}");
        
    }
}
