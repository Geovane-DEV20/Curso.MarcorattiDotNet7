// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("Passando argumentos por referencia");

int x = 20;
Console.WriteLine("\n Valor do argumento x antes de passar por valor" + x);

Calculo calc = new();
calc.Dobrar(ref x);

Console.WriteLine("\n Vaor do argumento x depois de passar por valor " + x);


ArgumetosReferenciaOut referencia = new();
referencia.ReferenciaOut();

Console.ReadKey();
public class Calculo
{
    public void Dobrar (ref int y) 
    { 
    
        y *= 2;
        Console.WriteLine("\n Valor do parametro y no método Dobrar " + y  );

    }   
}

public class ArgumetosReferenciaOut
{
    
    public void ReferenciaOut()
    {
        Console.WriteLine("Informe o raio do circulo");
        double raio = Convert.ToDouble(Console.ReadLine());

        Circulo circulo = new Circulo();

        double perimetro = circulo.CalculaPerimetro(raio);
        double area = circulo.CalculaArea(raio);

        Console.WriteLine("Perimetro da circunferencia " + perimetro);
        Console.WriteLine("Área de circunferência" + area);

        Console.ReadKey();

    }


}
public class Circulo
{
    public Double CalculaArea(double raio)
    {

        double area = Math.PI * Math.Pow(raio, 2);
        return area;
    }

    public double CalculaPerimetro(double raio) {
        double preimetro = 2 * Math.PI * raio;
        return preimetro;
    
    }

}