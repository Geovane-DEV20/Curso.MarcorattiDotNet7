// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Calculadora cal = new();
var valor = cal.Somar(2,2);
Console.WriteLine(cal.Somar(2, 2));
public class Calculadora
{
    public int Somar(int n1, int n2) 
    { 
        return n1 + n2;
    }
    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }
    public int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }

}