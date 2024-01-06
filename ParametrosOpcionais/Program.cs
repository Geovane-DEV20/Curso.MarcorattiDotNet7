// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Email email = new Email();
email.Enviar("geovane@teste.com"); 

Console.ReadKey();
public class Email
{
    public void Enviar(string destino, string titulo = "teste", string assunto = "teste do teste") // parametros opcionais
    {
        Console.WriteLine($"{destino}, {titulo}:{assunto}");

    }
}
