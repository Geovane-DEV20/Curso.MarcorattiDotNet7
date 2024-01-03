// See https://aka.ms/new-console-template for more information
Console.WriteLine("Passando argumentos por referencia");

int x = 20;
Console.WriteLine("\n Valor do argumento x antes de passar por valor" + x);

Calculo calc = new();
calc.Dobrar(ref x);

Console.WriteLine("\n Vaor do argumento x depois de passar por valor " + x);

Console.ReadKey();
public class Calculo
{
    public void Dobrar (ref int y) 
    { 
    
        y *= 2;
        Console.WriteLine("\n Valor do parametro y no método Dobrar " + y  );

    }   
}
