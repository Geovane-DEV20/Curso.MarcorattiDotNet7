


// A Implementação do método abstrato é feita na classe derivada
// Abstract nao pode ser instanciada
public abstract class Forma
{

    public string Cor { get; set; }
    public double Area { get; set; }
    public double Perimetro { get; set; }

    public abstract void CalcularArea();
    public abstract void CalcularPerimetro();

    public string Descrição()
    {
        return "Método comum da classe Forma";
    }
    
}


public class Quadrado : Forma
{
    public double Lado { get; set; }

    public override void CalcularArea()
    {
        this.Area = Lado * Lado;        
    }
    public override void CalcularPerimetro()
    {
        this.Perimetro = 4 * Lado;
    }

}
