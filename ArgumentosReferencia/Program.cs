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

        double circunferencia = circulo.CalculaAreaPerimetro(raio, out double area);

        Console.WriteLine("Perimetro da circunferencia " + circunferencia);
        Console.WriteLine("Área de circunferência" + area);

        Console.ReadKey();

    }


}
public class Circulo
{
    public double CalculaAreaPerimetro(double raio, out double area)
    {

        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return area;
    }



}