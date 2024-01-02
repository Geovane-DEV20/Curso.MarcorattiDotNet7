// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int x = 20;
Console.WriteLine("\nValor do argumnento x antes de passar por valor : " + x);
Calculo cal = new();
cal.Dobrar(x);
Console.WriteLine($"\n Valor do argumento x depois de passar por valor : " + x);

public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2;
        Console.WriteLine($"\nValor do parametro y no método Dobrar " + y);
    }
}