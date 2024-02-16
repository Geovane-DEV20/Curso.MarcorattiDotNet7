// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Upcasting 

Forma circulo = new Circulo(10, 20);
circulo.Desenhar(); // upcasting -> implicita

Circulo circuloOne = new Circulo();
Forma forma = circuloOne;
Circulo c = (Circulo)forma; //dowcasting -> explicita
c.PintarCirculo();  
c.Desenhar();  
public class Forma
{
    protected int xpos, ypos;
    public Forma()
    {
            
    }
    public Forma(int x, int y)
    {

        xpos = x;   
        ypos = y;   
    }

    public virtual void Desenhar()
    {
        Console.WriteLine("Desenhar - Forma");
    }

}

public class Circulo : Forma
{
    public Circulo()
    {
            
    }
    public Circulo(int x, int y) : base(x, y) { }

    public override void Desenhar()
    {
        Console.WriteLine("Desenhar - Circulo");
    }

    public void PintarCirculo()
    {
        Console.WriteLine("Pintar o circulo");
    }

}
