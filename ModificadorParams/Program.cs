// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] valores = { 1, 2, 30 };

var resultado = Calcular.Soma(valores);
Console.WriteLine(resultado);


Console.ReadKey();
public class Calcular
{
    public static int Soma(int[] numeros)
    {
        int total = 0;
        foreach (var numero in numeros)
        {
            total += numero;
        }
        return total;   
    }
}