// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Os metodos estaticos nao dependem de instancia de um objeto
// Pertecem a classe e nao objeto
var soma = Calculadora.Somar(2, 2);

Console.ReadKey();

public class Calculadora
{
    public static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public static int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    public static int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }
    public static int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }

}